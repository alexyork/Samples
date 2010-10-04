describe("FizzBuzz", function () {

    it("should return fizz for multiples of three", function () {
        var numbers = [3, 6, 9, 18, 33];

        for (var i = 0; i < numbers.length; i++) {
            var result = fizzBuzz.getResult(numbers[i]);
            expect(result).toEqual("fizz");
        }
    });

    it("should return buzz for multiples of five", function () {
        var numbers = [5, 10, 20, 40];

        for (var i = 0; i < numbers.length; i++) {
            var result = fizzBuzz.getResult(numbers[i]);
            expect(result).toEqual("buzz");
        }
    });

    it("should return fizzbuzz for multiples of three and five", function () {
        var numbers = [15, 30, 90];

        for (var i = 0; i < numbers.length; i++) {
            var result = fizzBuzz.getResult(numbers[i]);
            expect(result).toEqual("fizzbuzz");
        }
    });

    it("should return the number for non-multiples of three and five", function () {
        var numbers = [1, 2, 7, 19];

        for (var i = 0; i < numbers.length; i++) {
            var result = fizzBuzz.getResult(numbers[i]);
            expect(result).toEqual(numbers[i].toString());
        }
    });

    it("should return 0 for the number 0", function () {
        var result = fizzBuzz.getResult(0);
        expect(result).toEqual("0");
    });

});