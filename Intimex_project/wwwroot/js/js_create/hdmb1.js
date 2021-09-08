
function valuechange_khachhang(e) {
    var dataGrid = $("#khachhang").dxDataGrid("instance");
    if (dataGrid.length) {
        dataGrid.selectRows(e.value, false);
    }
}
function valuechange_hdmbchomuon(e) {
    var dataGrid = $("#hdmbchomuon").dxDataGrid("instance");
    if (dataGrid.length) {
        dataGrid.selectRows(e.value, false);
    }
}
function valuechange_intky(e) {
    var dataGrid = $("#intky").dxDataGrid("instance");
    if (dataGrid.length) {
        dataGrid.selectRows(e.value, false);
    }
}
function valuechange_khachky(e) {
    var dataGrid = $("#khachky").dxDataGrid("instance");
    if (dataGrid.length) {
        dataGrid.selectRows(e.value, false);
    }
}
function valuechange_thanhtoan(e) {
    var dataGrid = $("#thanhtoan").dxDataGrid("instance");
    if (dataGrid.length) {
        dataGrid.selectRows(e.value, false);
    }
}
function displayexpr_intky(item) {
    return item && item.Nguoiky + " chức vụ " + item.Chucvu;
}
function displayexpr_khachky(item) {
    return item && item.Nguoiky + " chức vụ " + item.Chucvu;
}
function displayexpr_thanhtoan(item) {
    return item && item.Matt + "<" + item.TenTt + ">";
}
function displayexpr_hdmbchomuon(item) {
    return item && item.Systemref + " < " + item.Sohd + " > ";
}
function onSelectionChanged(selectionChangedArgs, component) {
    var setValue = component.option('setValue');
    var selectedRowKey = selectionChangedArgs.selectedRowKeys[0];

    component.option('value', selectedRowKey);
    setValue(selectedRowKey);
    if (selectionChangedArgs.selectedRowKeys.length > 0) {
        component.close();
    }
}
function PopupFormEdit(url) {
    var form = $('<div/>');
    $.get(url)
        .done(function (response) {
            form.html(response);
            Popup = form.dialog({
                autoOpen: true,
                resizable: false,
                title: 'Chỉnh sửa chi tiết hợp đồng',
                height: 500,
                width: 700,
                close: function () {
                    Popup.dialog('destroy').remove();
                }

            });
        });
};
function getDataGridInstance() {
    return $("#hdmb").dxDataGrid("instance");
}
function toolbarcthdmb(e) {
    e.toolbarOptions.items.unshift({
        location: "after",
        widget: "dxButton",
        options: {
            icon: "add",
            onClick: function () {
                getDataGridInstance().getSelectedRowsData().done(function (rowData) {
                    for (var i = 0; i < rowData.length; i++) {
                        if (rowData[i].IsFix == true) {
                            var id = rowData[i].Systemref;
                            var url = "hopdong/addcthd/" + id;
                            var formDiv = $('<div/>');
                            $.get(url)
                                .done(function (response) {
                                    formDiv.html(response);
                                    Popup = formDiv.dialog({
                                        autoOpen: true,
                                        resizable: false,
                                        title: 'Thêm chi tiết hợp đồng giá trừ lùi',
                                        height: 500,
                                        width: 700,
                                        close: function () {
                                            Popup.dialog('destroy').remove();
                                        }

                                    });
                                });
                        }
                        else {
                            var id = rowData[i].Systemref;
                            var url = "hopdong/addcthdoutright/" + id;
                            var formDiv = $('<div/>');
                            $.get(url)
                                .done(function (response) {
                                    formDiv.html(response);
                                    Popup = formDiv.dialog({
                                        autoOpen: true,
                                        resizable: false,
                                        title: 'Thêm chi tiết hợp đồng giá OutRight',
                                        height: 500,
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
        }
    });
}
function toolbarhdmb(e) {
    e.toolbarOptions.items.unshift({
        location: "after",
        widget: "dxButton",
        options: {
            icon: "add",
            onClick: function () {
                location.href = "hopdong/themhopdong"

            }
        }
    });
}