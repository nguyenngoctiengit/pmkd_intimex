"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton1").disabled = true;

$("#countMessage").mouseover(function () {
    $("#countMessage").html('0');
})

function createLi_message(sender, nguoiGui, message) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var a = document.createElement('a');
    a.className = 'dropdown-item';
    a.href = '/home/PartialViewChat/' + sender;
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
        '<p  onclick="DownloadDocument(\'' + msg + '\')" style="cursor: pointer">' + msg + '</p>' +
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
        '<p  onclick="DownloadDocument(\'' + msg + '\')" style="cursor: pointer">' +
        msg +
        '</p >' +
        '<span class="time_date">' + datetime + '</span>' +
        '</div >';
    div.className = 'outgoing_msg';
    document.getElementById('createDiv_outgoing_msg').appendChild(div);
}

connection.on("ReceiveMessage", function (sender, reciever, message, nguoiGui) {
    var datetime = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var senderInput = document.getElementById("senderInput").value;
    var scrolElement = (document.getElementById('msg_history'));
    if (senderInput == sender) {
        createDiv_outgoing_msg(msg);
        scrolElement.scrollTop = scrolElement.scrollHeight - scrolElement.clientHeight;
        document.getElementById('fileUpload').value = null;
        document.getElementById('messageInput1').value = '';
        document.getElementById('messageInput1').focus();
    }
    else {
        createDiv_incoming_msg(msg);
        scrolElement.scrollTop = scrolElement.scrollHeight - scrolElement.clientHeight;
        document.getElementById('fileUpload').value = null;
        document.getElementById('messageInput1').value = '';
        document.getElementById('messageInput1').focus();
        var count = $("#countMessage").html();
        count++;
        $("#countMessage").html(count);
        $.notify("You are recieve a message from " + nguoiGui, "success");
        createLi_message(sender, nguoiGui, message);
    }
});

connection.start().then(function () {
    document.getElementById("sendButton1").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

function randomString(length) {
    var result = '';
    var characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
    var charactersLength = characters.length;
    for (var i = 0; i < length; i++) {
        result += characters.charAt(Math.floor(Math.random() *
            charactersLength));
    }
    return result;
}

var UploadFile = function (e) {
    var file = document.getElementById('fileUpload').value;
    var extensionFile = file.split(/(\\|\/)/g).pop();
    var sender = document.getElementById("senderInput").value;
    var receiver = document.getElementById("receiverInput").value;
    var message = extensionFile;
    var allowedFiles = ["docx", "jpg", "jpeg", "gif", "png", "doc", "pdf", "xls",
        "xlsx", "xlsm", "pptx", "pptm", "ppt", "txt", "mp3", "mp4", "rar", "zip"];
    var regex = new RegExp("([a-zA-Z0-9\s_\\.\-:])+(" + allowedFiles.join('|') + ")$");
    if (!regex.test(file.toLowerCase())) {
        $.notify("Please upload files having extensions: " + allowedFiles.join(', ') + " only.", "error");
        document.getElementById('fileUpload').value = null;
        return false;
    }
    else {
        var file = e.target.files[0];
        var formData = new FormData();
        var newFileName = randomString(6) + "_" + extensionFile;
        formData.append("file", file, newFileName);
        axios.post("/Home/Upload", formData);
        $.notify("Upload file success", "success");
        if (receiver != "") {
            connection.invoke("SendMessageToGroup", sender, receiver, newFileName).catch(function (err) {
                return console.error(err.toString());
            });
        }

    }


}

document.getElementById("sendButton1").addEventListener("click", function (event) {
    var sender = document.getElementById("senderInput").value;
    var receiver = document.getElementById("receiverInput").value;
    var message = document.getElementById("messageInput1").value;
    if (receiver != "") {

        connection.invoke("SendMessageToGroup", sender, receiver, message).catch(function (err) {
            return console.error(err.toString());
        });
        $("#emojionearea-editor").html();
    }
    else {
        connection.invoke("SendMessage", sender, message).catch(function (err) {
            return console.error(err.toString());
        });
    }


    event.preventDefault();
});