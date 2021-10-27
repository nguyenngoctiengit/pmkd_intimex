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

function createLi_message(id, sender, nguoiGui, message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var a = document.createElement('a');
    a.className = 'dropdown-item';
    a.href = '/home/ViewNotification/' + id;
    a.style.color = 'black';
    a.innerHTML = '<span class="image"><img src="/public/images/img.jpg" alt="Profile Image" /></span>' +
        '<span>' +
        '<span>' + nguoiGui + '</span>' +
        '<span class="time" style="text-align:right;">' + datetime + '</span>' +
        '</span>' +
        '<span class="message">' +
        msg +
        '</span>';
    document.getElementById("messageIncoming").appendChild(a);
}

function updateNotification() {
    $('#messageIncoming').empty();
    $.ajax({
        type: 'GET',
        url: '/home/GetNotification',
        success: function (respone) {
            $.each(respone, function (index, value) {
                createLi_message(value.id, value.FromUser, value.nguoiGui, value.Message1);
            })
        },
        error: function (error) {
            console.log(error);
        }
    })
}

connection.on("ReceiveMessage", function (sender, reciever, message, nguoiGui) {
    var userId = document.getElementById('userId').value;
    if (reciever == userId) {
        var count = $("#countMessage").html();
        count++;
        $("#countMessage").html(count);
        $.notify("You are recieve a message from " + nguoiGui, "success");
    }
});