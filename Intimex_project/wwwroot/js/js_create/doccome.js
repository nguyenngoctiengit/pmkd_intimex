﻿function toolbar_DocCome(e) {
    e.toolbarOptions.items.unshift({
        location: "after",
        widget: "dxButton",
        options: {
            icon: "add",
            onClick: function () {
                location.href = "/doccome/AddDocCome";
            }
        }
    });
    e.toolbarOptions.items.unshift({
        location: "after",
        widget: "dxButton",
        options: {
            icon: "edit",
            onClick: function () {
                alert(1);
            }
        }

    })
}