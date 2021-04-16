
/*function valuechange_xuatkhau(e) {
    var item_return = $("#selectedBox_xuatkhau").dxSelectBox('instance').option('value');
    var form = $("#formLenhgiaohang").dxForm('instance');
    if (item_return == 2) {
        form.itemOption("basic.KhachMua", "visible", true);
        form.itemOption("basic.HopdongMua", "visible", true);
    } else {
        form.itemOption("basic.KhachMua", "visible", false);
        form.itemOption("basic.HopdongMua", "visible", false);
    }
}*/
function calculateFilterExpression_lenhgiaohang() {
    var d = new Date()
    var dd = d.getDate();
    var mm = d.getMonth() + 1;
    var yyyy = d.getFullYear();
    var today = mm + '-' + dd + '-' + yyyy;
    return [[getOrderDay, '=', today]];
}
