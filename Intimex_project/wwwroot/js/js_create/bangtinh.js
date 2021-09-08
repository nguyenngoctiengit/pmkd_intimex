function valuechange_xevc_bt(e) {
    var dataGrid = $("#xevc_bt").dxDataGrid("instance");
    if (dataGrid.length) {
        dataGrid.selectRows(e.value, false);
    }
}