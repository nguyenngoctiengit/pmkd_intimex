"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

function createDivSent_msg(mess, datetime) {
    var div = document.createElement("div");
    var div1 = document.createElement("div");
    div.className = 'outgoing_msg';
    document.getElementById("outgoing_msg").appendChild(div);
    div1.className = 'sent_msg';
    div1.innerHTML = '<p>' + mess + '</p>' + '<span class="time_date">' + datetime + '</span>';
    document.getElementById('sent_msg').appendChild(div1);
}


function createDivRecieve_msg(mess, datetime) {
    var div = document.createElement("div");
    div.className = 'incoming_msg';
    document.getElementById('incoming_msg').appendChild(div);
    var div1 = document.createElement("div");
    div1.className = 'received_msg';
    document.getElementById("received_msg").appendChild(div1);
    var div2 = document.createElement("div");
    div2.className = 'received_withd_msg';
    div2.innerHTML = '<p>' + mess + '</p>' + '<span class="time_date">' + datetime + '</span>';
    document.getElementById("received_withd_msg").appendChild(div2);
}

connection.on("GetAllActiveConnections", function (item) {
    console.log(item);
})

connection.on("ReceiveMessage", function (sender, reciever, message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var senderInput = document.getElementById("senderInput").value;
    if (senderInput == sender) {
        createDivSent_msg(encodedMsg, datetime);
        window.scrollTo(0, document.querySelector(".msg_history").scrollHeight);
        window.location.reload();
        
    }
    else {        
        createDivRecieve_msg(encodedMsg, datetime); 
        window.scrollTo(0, document.querySelector(".msg_history").scrollHeight);
        window.location.reload();
        
    }
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var sender = document.getElementById("senderInput").value;
    var receiver = document.getElementById("receiverInput").value;
    var message = document.getElementById("messageInput").value;

    if (receiver != "") {

        connection.invoke("SendMessageToGroup", sender, receiver, message).catch(function (err) {
            return console.error(err.toString());
        });
    }
    else {
        connection.invoke("SendMessage", sender, message).catch(function (err) {
            return console.error(err.toString());
        });
    }


    event.preventDefault();
});