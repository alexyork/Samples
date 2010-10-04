describe("Calculator", function () {

    it("should add two numbers correctly", function () {
        var result = calculator.add(10, 1);
        expect(result).toEqual(11);
    });

    it("should subtract two numbers correctly", function () {
        var result = calculator.subtract(10, 1);
        expect(result).toEqual(9);
    });

});