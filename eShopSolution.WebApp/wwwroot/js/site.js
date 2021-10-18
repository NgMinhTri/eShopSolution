﻿$('body').on('click', '.btn-add-cart', function (e) {
    e.preventDefault();
    const culture = $('#hidCulture').val();
    const id = $(this).data('id');
    $.ajax({
        type: "POST",
        url: "/" + culture + '/Cart/AddToCart',
        data: {
            id: id,
            languageId: culture
        },
        success: function (res) {
            console.log(res)
        },
        error: function (err) {
            console.log(err);
        }
    });
})