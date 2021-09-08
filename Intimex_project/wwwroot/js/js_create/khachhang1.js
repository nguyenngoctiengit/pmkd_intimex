function valueChange_tenqg(data) {
    var item_return = document.getElementById('tenqg');
    item_return.value = data.value;
}
function toolbar_khachhang(e) {
    e.toolbarOptions.items.unshift({
        location: "after",
        widget: "dxButton",
        options: {
            icon: "add",
            onClick: function () {
                location.href = "/khachhang/themkhachhang"

            }
        }
    });
}
