pmkd.khachhang = function () {
    var grid;
    var KHPopup;
    var formSelector = "#details-form";
    var showDetailsPopup = function (data) {
        KHPopup.show();
        var form = $(formSelector).dxForm("instance");
        form.option({
            formData: data
        });
        var lableText;
        if (data) {
            lableText = "Cập nhật khách hàng";
        } else {
            lableText = "Thêm khách hàng";
        }   
        $("#grid-details-label").text(labelText);
    }
    
    this.createNewKH = function () {
        showDetailsPopup();
    };
    this.init = function () {
        KHPopup = $("#details-form-popup").dxPopup("instance");
    }
}
$(function () {
    pmkd.khachhang.init();
})