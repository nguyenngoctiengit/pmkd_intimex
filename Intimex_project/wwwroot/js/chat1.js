"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (sender, reciever, message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var senderInput = document.getElementById("senderInput").value;
    if (senderInput == sender) {
        window.location.reload();
    }
    else {
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