"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says: " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

let onlineCount = document.querySelector('span.online-count');




connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    function GetAllActiveConnections() {
        connection.invoke("GetAllActiveConnections").then(function (item) {
            for (var user in item) {
                document.getElementById("listUser").innerHTML += '<li><a asp-action="chat" asp-controller="home" asp-route-id="' + item[user] + '"><i class="fas fa-user"></i>' + item[user] + '</a></li>';
                console.log(item);
            }
            
        })
    }
    GetAllActiveConnections();
    /*setInterval(function () {
        connection.invoke("GetAllActiveConnections").then(function (item) {
            document.getElementById("listUser").innerHTML += '<li>' + item + '</li>';
        });
    }, 3000)  */
}).catch(function (err) {
    return console.error(err.toString());
});

let updateCountCallback = function (message) {
    if (!message) return;
    console.log('updateCount = ' + message);
    if (onlineCount) onlineCount.innerText = message;
};

connection.on('updateCount', updateCountCallback);

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