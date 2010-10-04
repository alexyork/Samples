var fizzBuzz = function () {


    var getResult = function (number) {

        if (isMultipleOfThreeAndFive(number)) {
            return "fizzbuzz";
        }
        if (isMultipleOfThree(number)) {
            return "fizz";
        }
        if (isMultipleOfFive(number)) {
            return "buzz";
        }
        return number.toString();
    };

    var isMultipleOfThreeAndFive = function (number) {
        return isMultipleOfFive(number) && isMultipleOfThree(number);
    };

    var isMultipleOfThree = function (number) {
        return number % 3 == 0 && number != 0;
    };

    var isMultipleOfFive = function (number) {
        return number % 5 == 0 && number != 0;
    };

    return {
        getResult: getResult
    };

} ();