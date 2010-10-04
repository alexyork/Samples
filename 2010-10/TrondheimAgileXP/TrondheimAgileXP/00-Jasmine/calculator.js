var calculator = function () {

    var add = function (x, y) {
        return x + y;
    };

    var subtract = function (x, y) {
        return x - y;
    };

    return {
        add: add,
        subtract: subtract
    };

} ();