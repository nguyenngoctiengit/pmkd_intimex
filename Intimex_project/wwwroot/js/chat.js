"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton1").disabled = true;

$("#countMessage").mouseover(function () {
    $("#countMessage").html('0');
})


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
    var file1 = document.getElementById('fileUpload');
    var filesize = file1.files[0].size;
    if (filesize >= 52428800) {
        $.notify("Please upload files having size is bigger than: " + 52428800 + ".", "error");
        document.getElementById('fileUpload').value = null;
        return false;
    } else if (!regex.test(file.toLowerCase())) {
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
    if (document.getElementById('messageInput1').value != '') {
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
    } else {
        document.getElementById('messageInput1').focus();
    }
});
$(window).on('load', function () {
    $('.loader').fadeOut(1000);
    $('.container').fadeIn(1000);
    scrollChat();
})

document.getElementById('messageInput1').addEventListener('keyup', function (event) {
    event.preventDefault();
    if (event.keyCode === 13) {
        document.getElementById('sendButton1').click();
    }
});

function DownloadDocument(id) {
    var extensionFile = ["docx", "jpg", "jpeg", "gif", "png", "doc", "pdf", "xls",
        "xlsx", "xlsm", "pptx", "pptm", "ppt", "txt", "mp3", "mp4", "rar", "zip"];
    var regex = new RegExp("([a-zA-Z0-9\s_\\.\-:])+(" + extensionFile.join('|') + ")$");
    if (!regex.test(id.toLowerCase())) {
        $.notify("This is not a file. Cannot download !!", "error");
    } else {
        location.href = '/home/DownloadDocument/' + id;
    }
}

function Search() {
    var searchKey = document.getElementById('keySearch');
    var filter = searchKey.value.toUpperCase();
    var button = document.querySelectorAll('.buttonChat');
    for (var i of button) {
        var item = i.value;
        if (item.toUpperCase().indexOf(filter) > -1) {
            i.style.display = '';
        } else {
            i.style.display = 'none';
        }
    }
}
function SearchMessage() {
    var searchKey = document.getElementById('keySearchMessage');
    var filter = searchKey.value.toUpperCase();
    var count = 0;
    $('#msg_history div').each(function () {
        if ($(this).text().search(new RegExp(filter, "i")) < 0) {
            $(this).hide();  // MY CHANGE

            // Show the list item if the phrase matches and increase the count by 1
        } else {
            $(this).show(); // MY CHANGE
            count++;
        }
    })
}
$('.msg_history').scroll(function () {
    if ($('.msg_history').scrollTop() == 0) {
        if (GetDataMessage() != 0) {
            GetDataMessage();
            $('.msg_history').scrollTop(30);
        }
    }
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
    var senderInput = document.getElementById('senderInput').value;
    $.ajax({
        type: 'GET',
        url: '/home/GetNotification',
        success: function (respone) {
            $.each(respone, function (index, value) {
                if (value.FromUser == senderInput) {

                }
                else {
                    createLi_message(value.id, value.FromUser, value.nguoiGui, value.Message1);
                }

            })
        },
        error: function (error) {
            console.log(error);
        }
    })
}

var pageSize = 10;
var pageIndex = 1;
var id = document.getElementById('receiverInput').value;
var sender = document.getElementById('senderInput').value;
var receiver = document.getElementById('receiverInput').value;
function GetDataMessage() {
    $.ajax({
        type: 'GET',
        url: '/home/GetDataMessage',
        data: { "pageindex": pageIndex, "pagesize": pageSize, "id": id },
        dataType: 'json',
        success: function (data) {
            if (data != null) {
                for (var i = 0; i < data.length; i++) {
                    if (data[i].FromUser == sender && data[i].ToUser == receiver) {
                        $('#msg_history').prepend(' <div class="outgoing_msg">' +
                            '<div class="sent_msg">' +
                            '<p onclick="DownloadDocument(\'' + data[i].Message1 + '\')" style="cursor: pointer">'
                            + data[i].Message1 +
                            '</p>' +
                            '<span class="time_date">' + data[i].Date + '</span>' +
                            '</div>' +
                            '</div>');

                    } else {
                        $('#msg_history').prepend('<div class="incoming_msg">' +
                            '<div class="incoming_msg_img">' +
                            '<img src="/Images/Avatar.PNG" />' +
                            ' </div>' +
                            '<div class="received_msg">' +
                            '<div class="received_withd_msg">' +
                            '<p onclick="DownloadDocument(\'' + data[i].Message1 + '\')" style="cursor: pointer">' + data[i].Message1 + '</p>' +
                            '<span class="time_date">' + data[i].Date + '</span>' +
                            '</div>' +
                            '</div>' +
                            '</div>');
                    }
                }

            }

        },
        error: function () {
            alert('Đã load hết dữ liệu chat !!');
        }
    })
    pageIndex++;
}