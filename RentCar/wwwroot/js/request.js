

var skipCount = parseInt($("#skipCount").val());
console.log(skipCount);
$(document).on("click", "#loadmore-car-btn", function () {
    $.ajax({
        type: "GET",
        url: "Home/LoadMore/" + skipCount,
        success: function (res) {
            skipCount += 4;
            $("#carModel-card-box").append(res);
        }
    })
})


//accordion 

$("#car-brand-select").change(function () {
    var carValue = $(this).val();
    //$.ajax({
    //    type: "GET",
    //    url: "Home/Search/" + carValue,
    //    success: function (res) {
    //        $("#car-model-select").append(res);
    //    }
    //})
});