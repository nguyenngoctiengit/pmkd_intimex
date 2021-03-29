
function onSelectionChanged(selectionChangedArgs, component) {
    var setValue = component.option('setValue');
    var selectedRowKey = selectionChangedArgs.selectedRowKeys[0];

    component.option('value', selectedRowKey);
    setValue(selectedRowKey);
    if (selectionChangedArgs.selectedRowKeys.length > 0) {
        component.close();
    }
}
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






