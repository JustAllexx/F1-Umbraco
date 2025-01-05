$(document).ready(function () {
    $(".video-button").on("click", function () {
        $("body").css("overflow", "hidden");
        $(this).closest(".video-container").find(".screen-cover").toggle();
    });

    $(".f1-close").on("click", function () {
        $("body").css("overflow", "auto");
        $(this).closest(".screen-cover").toggle();
    });
})