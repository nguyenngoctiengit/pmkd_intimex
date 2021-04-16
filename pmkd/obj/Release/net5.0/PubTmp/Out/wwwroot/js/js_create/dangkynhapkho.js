function OnShowing(e) {
    var component = $("#grid").dxDataGrid("instance");
    if (component.__addingStart) {
        var $formContainer = component.__editor.closest('[role="form"]');
        $formContainer.dxForm('instance').itemOption('Status', 'visible', false);
        $formContainer.dxForm('instance').itemOption('Aprove', 'visible', false);
        $formContainer.dxForm('instance').itemOption('IsHoanThanh', 'visible', false);
        $formContainer.dxForm('instance').itemOption('KhoName', 'visible', false);
        $formContainer.dxForm('instance').itemOption('KhachHang', 'visible', false);
        $formContainer.dxForm('instance').itemOption('Tenhang', 'visible', false);
        component.__addingStart = false;
    }
}
function OnInitNewRow(e) {
    e.component.__addingStart = true;
}
function OnEditorPrepared(e) {
    if (e.component.__addingStart && e.dataField == "Status") {
        e.component.__editor = e.editorElement;
    }
    if (e.component.__addingStart && e.dataField == "Aprove") {
        e.component.__editor = e.editorElement;
    }
    if (e.component.__addingStart && e.dataField == "IsHoanThanh") {
        e.component.__editor = e.editorElement;
    }
    if (e.component.__addingStart && e.dataField == "KhachHang") {
        e.component.__editor = e.editorElement;
    }
    if (e.component.__addingStart && e.dataField == "Tenhang") {
        e.component.__editor = e.editorElement;
    }
    if (e.component.__addingStart && e.dataField == "KhoName") {
        e.component.__editor = e.editorElement;
    }

}
function calculateFilterExpression() {
    var d = new Date()
    var dd = d.getDate();
    var mm = d.getMonth() + 1;
    var yyyy = d.getFullYear();
    var today = mm + '-' + dd + '-' + yyyy;
    return [[getOrderDay, '=', today]];
}
