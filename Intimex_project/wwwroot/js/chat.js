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

connection.on("ReceiveMessage", function (sender, reciever, message) {
    var userId = document.getElementById('userId').value;
    if (reciever == userId) {
        var count = $("#countMessage").html();
        count++;
        $("#countMessage").html(count);
        $.notify("You are recieve a message from " + sender, "success");
    }
});