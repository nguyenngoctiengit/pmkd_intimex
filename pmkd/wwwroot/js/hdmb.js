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
function onSelectionChanged(selectionChangedArgs, component) {
    var setValue = component.option('setValue');
    var selectedRowKey = selectionChangedArgs.selectedRowKeys[0];

    component.option('value', selectedRowKey);
    setValue(selectedRowKey);
    if (selectionChangedArgs.selectedRowKeys.length > 0) {
        component.close();
    }
}
function allowDeleting(e) {
    return (e.row.data.Systemref != "HD00037227")
}





