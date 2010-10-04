(function ($) {
    $.fn.listify = function () {

        this.children(":even").addClass("even");
        this.children(":odd").addClass("odd");
        return this;

    };
})(jQuery);