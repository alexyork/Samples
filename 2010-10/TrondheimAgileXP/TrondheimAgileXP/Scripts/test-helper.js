beforeEach(function () {
    this.addMatchers({

        isAlexYork: function (expectedName) {
            return this.actual === "Alex York";
        }

    })
});
