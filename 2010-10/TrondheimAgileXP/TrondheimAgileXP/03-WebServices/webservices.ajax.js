var webServices = function () {

    var getProducts = function (successCallback) {
        jQuery.ajax({
            'url': "Products.asmx",
            'dataType': "json",
            'success': function () {
                if (successCallback) {
                    successCallback();
                }
            }
        });
    };

    return {
        getProducts: getProducts
    };

} ();