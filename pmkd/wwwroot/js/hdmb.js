var TypeKd = [{
    "id": 0, "name": "Trực tiếp"
}, {
    "id": 1, "name": "Ủy thác"
}
];
var Trangthai = [{
    "id": 0, "name": "Thanh lí"
}, {
    "id": 1, "name": "Mới"
}, {
    "id": 2, "name": "Hủy"
}
];
var isfix = [{
    "id": false, "name": "Giá Outright"
}, {
    "id": true, "name": "Giá trừ lùi"
}
];
function onSelectionChanged(selectionChangedArgs, component) {
    var setValue = component.option('setValue');
    var selectedRowKey = selectionChangedArgs.selectedRowKeys[0];

    component.option('value', selectedRowKey);
    setValue(selectedRowKey);
    if (selectionChangedArgs.selectedRowKeys.length > 0) {
        component.close();
    }
}

function selected_item(e) {
    var selectedRowData = e.selectedRowsData[0];
    
}
function getDataGridInstance() {
    return $("#hdmb").dxDataGrid("instance");
}

function toolbar(e) {
    e.toolbarOptions.items.unshift({
        location: "after",
        widget: "dxButton",
        options: {
            icon: "add",
            onClick: function () {
                getDataGridInstance().getSelectedRowsData().done(function (rowData) {
                    for (var i = 0; i < rowData.length; i++) {
                        if (rowData[i].IsFix === null) {
                            alert("Vui lòng click vào hợp đồng muốn thêm chi tiết")
                        }
                        else {
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


                        
                    }

                })
                
            }
        }
    });
}
function hdmb(e) {
    var selected = e.component.getSelectedRowsData()[0];
    alert(selected.IsFix);
}
