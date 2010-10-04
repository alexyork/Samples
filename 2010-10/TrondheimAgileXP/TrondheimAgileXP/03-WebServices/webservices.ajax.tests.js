describe("My webservices AJAX module", function () {

    beforeEach(function () {
        spyOn(jQuery, "ajax").andCallFake(function (options) {
            options.success();
        });
    });

    it("should make an AJAX request", function () {
        webServices.getProducts();
        expect(jQuery.ajax.callCount).toEqual(1);
    });

    it("should make an AJAX request to the URL 'Products.asmx'", function () {
        webServices.getProducts();
        expect(jQuery.ajax.mostRecentCall.args[0].url).toEqual("Products.asmx");
    });

    it("should make an AJAX request of dataType 'json'", function () {
        webServices.getProducts();
        expect(jQuery.ajax.mostRecentCall.args[0].dataType).toEqual("json");
    });

    it("should call through to the success callback function", function () {
        var successCallback = jasmine.createSpy();
        webServices.getProducts(successCallback);
        expect(successCallback).toHaveBeenCalled();
    });

});