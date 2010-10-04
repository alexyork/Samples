module("this module will pass all its tests");

test("a basic test example", function () {
    var value = "hello";
    equals("hello", value, "We expect value to be hello");
});


module("this module will fail the second test");

test("adding two numbers", function () {
    var value = 2 + 2;
    equals(4, value, "We expect value to be 4");
});

test("subtracting two numbers", function () {
    var value = 2 - 2;
    equals(42, value, "We expect value to be 0");
});