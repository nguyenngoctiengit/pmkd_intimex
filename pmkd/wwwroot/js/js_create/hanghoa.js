function toolbarhanghoa(e) {
    e.toolbarOptions.items.unshift({
        location: "after",
        widget: "dxButton",
        options: {
            text: "Thêm nhóm hàng",
            width: 150,
            onClick: function () {
                var url = "/hanghoa/themnhomhang";
                var formDiv1 = $('<div/>');
                $.get(url)
                    .done(function (response) {
                        formDiv1.html(response);
                        Popup = formDiv1.dialog({
                            autoOpen: true,
                            resizable: true,
                            title: 'Thêm nhóm hàng hóa',
                            height: 300,
                            width: 700,
                            close: function () {
                                Popup.dialog('destroy').remove();
                            }
                        });
                    });
            }
        }
    })
}

