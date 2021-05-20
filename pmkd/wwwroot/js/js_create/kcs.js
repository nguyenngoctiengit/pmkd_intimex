function calculateFilterExpression_kcs() {
    var d = new Date()
    var dd = d.getDate();
    var mm = d.getMonth() + 1;
    var yyyy = d.getFullYear();
    var today = mm + '-' + dd + '-' + yyyy;
    return [[getOrderDay, '=', today]];
}
function valuechange_xevc(e) {
    var dataGrid = $("#xevc").dxDataGrid("instance");
    if (dataGrid.length) {
        dataGrid.selectRows(e.value, false);
    }
}
function toolbar_kcs(e) {
    e.toolbarOptions.items.unshift({
        location: "after",
        widget: "dxButton",
        options: {
            icon: "add",
            onClick: function () {
                location.href = "kho/themkcs";
            }
        }
    });
}
