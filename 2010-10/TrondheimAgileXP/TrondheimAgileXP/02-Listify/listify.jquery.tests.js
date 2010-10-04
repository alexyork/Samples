describe("Listify jQuery plugin", function () {

    beforeEach(function () {
        jasmine.getFixtures().set(
            "<ul id='MyList'> <li></li> <li></li> <li></li> </ul>");
    });

    it("should add the css class 'even' to all even list items", function () {
        $("#MyList").listify();

        var hasEvenCssClass = $("#MyList li:even").hasClass("even");
        expect(hasEvenCssClass).toEqual(true);
    });

    it("should add the css class 'odd' to all odd list items", function () {
        $("#MyList").listify();

        var hasOddCssClass = $("#MyList li:odd").hasClass("odd");
        expect(hasOddCssClass).toEqual(true);
    });

    it("should return the jQuery object", function () {
        var returnValue = $("#MyList").listify();
        expect(returnValue).toBeDefined();
    });

});