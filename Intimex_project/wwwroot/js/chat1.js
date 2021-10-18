"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

function createDiv_incoming_msg(message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var div = document.createElement('div');
    div.innerHTML = '<div class="incoming_msg">' +
        '<div class="incoming_msg_img">' +
        '<img src="/Images/Avatar.PNG" />' +
        '</div >' +
        '<div class="received_msg">' +
        '<div class="received_withd_msg">' +
        '<p>' + msg + '</p>' +
        '<span class="time_date">' + datetime + '</span>' +
        '</div>' +
        '</div>' +
        ' </div >';
    document.getElementById('createDiv_outgoing_msg').appendChild(div);
}

function createDiv_outgoing_msg(message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var div = document.createElement('div');
    div.innerHTML = '<div class="sent_msg">' +
        '<p>' +
        msg +
        '</p >' +
        '<span class="time_date">' + datetime + '</span>' +
        '</div >'
    div.className = 'outgoing_msg';
    document.getElementById('createDiv_outgoing_msg').appendChild(div);
}

connection.on("ReceiveMessage", function (sender, reciever, message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var senderInput = document.getElementById("senderInput").value;
    var scrolElement = (document.getElementById('msg_history'));
    if (senderInput == sender) {
        createDiv_outgoing_msg(msg);
        document.querySelector('#messageInput1').value = '';
        scrolElement.scrollTop = scrolElement.scrollHeight - scrolElement.clientHeight;
        document.querySelector('#messageInput1').focus();
        document.getElementById('fileUpload').value = null;
    }
    else {
        createDiv_incoming_msg(msg);
        document.querySelector('#messageInput1').value = '';
        scrolElement.scrollTop = scrolElement.scrollHeight - scrolElement.clientHeight;
        document.querySelector('#messageInput1').focus();
        document.getElementById('fileUpload').value = null;
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

/*document.getElementById('fileUpload').onchange = function () {
    var x = document.getElementById('fileUpload').value;
    var item = x.split(/(\\|\/)/g).pop();
    var sender = document.getElementById("senderInput").value;
    var receiver = document.getElementById("receiverInput").value;
    var message = item;
    if (receiver != "") {
        connection.invoke("SendMessageToGroup", sender, receiver, message).catch(function (err) {
            return console.error(err.toString());
        });
    }
}*/
var UploadFile = function (e) {
    var x = document.getElementById('fileUpload').value;
    var item = x.split(/(\\|\/)/g).pop();
    var sender = document.getElementById("senderInput").value;
    var receiver = document.getElementById("receiverInput").value;
    var message = item;
    if (receiver != "") {
        connection.invoke("SendMessageToGroup", sender, receiver, message).catch(function (err) {
            return console.error(err.toString());
        });
    }
    var file = e.target.files[0];
    var formData = new FormData();
    formData.append("file", file);
    axios.post("/Home/Upload", formData);
}

document.getElementById('fileUpload').onchange = function () {
    alert(document.getElementById("fileUpload").file[0]);
}

document.getElementById("sendButton1").addEventListener("click", function (event) {
    var sender = document.getElementById("senderInput").value;
    var receiver = document.getElementById("receiverInput").value;
    var message = document.getElementById("messageInput1").value;
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