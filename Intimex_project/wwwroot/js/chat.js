"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

function createDiv_outgoing_msg(message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var div = document.createElement('div');
    div.innerHTML = '<div class="incoming_msg">'+
        '< div class="incoming_msg_img" >'+
            '<img src="~/Images/Avatar.PNG" />'+
                                    '</div >'+
        '<div class="received_msg">'+
        '<div class="received_withd_msg">' +
        '<p>' + msg + '</p>' +
        '<span class="time_date">' + datetime + '</span>' +
            '</div>' +
            '</div>' +
        ' </div >';
    document.getElementById('createDiv_outgoing_msg').appendChild(div);
}

connection.on("ReceiveMessage", function (sender, reciever, message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var senderInput = document.getElementById("senderInput").value;
    if (senderInput == sender) {
        createDiv_outgoing_msg(msg);
        document.getElementById('messageInput').focus();
    }
    else {
        console.log(datetime);
        document.getElementById('messageInput').focus();

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