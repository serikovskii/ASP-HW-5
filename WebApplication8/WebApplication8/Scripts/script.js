$(".btn").on("click", function () {
    var nik = $("#nik").val();
    var text = $("#text").val();
    var json1 = { "Nik": nik, "Text": text };
    $.ajax({
        type: "POST",
        url: "ProcessData",
        data: json1,
        dataType: "json",
        success: function () {
            $(".wall").append(nik + " - " + text + "<br>"); 
        }
    })     
})

$.ajax({
    type: "POST",
    url: "ProcessData",
    success: function (json) {
        console.log(json);
        for (var i = 0; i < json.length; i++) {
            $(".wall").append(json[i].Nik + " - " + json[i].Text + "<br>");
        }
    }
})

