"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

$("#countMessage").mouseover(function () {
    $("#countMessage").html('0');
})

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

function createLi_message(sender,nguoiGui, message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var a = document.createElement('a');
    a.className = 'dropdown-item';
    a.style = 'color:black';
    a.href = '/home/PartialViewChat/' + sender;
    a.innerHTML = '<span class="image"><img src="/public/images/img.jpg" alt="Profile Image" /></span>' +
        '<span>' +
        '<span>' + nguoiGui + '</span>' +
        '<span class="time" style="right:5px">' + datetime + '</span>' +
        '</span>' +
        '<span class="message">' +
        msg +
        '</span>';
    document.getElementById("messageIncoming").appendChild(a);
}

connection.on("ReceiveMessage", function (sender, reciever, message, nguoiGui) {
    var userId = document.getElementById('userId').value;
    if (reciever == userId) {
        var count = $("#countMessage").html();
        count++;
        $("#countMessage").html(count);
        createLi_message(sender, nguoiGui, message);
        $.notify("You are recieve a message from " + nguoiGui, "success");
    }
});