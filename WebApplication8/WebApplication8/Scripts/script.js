$("#btn").on("click", function() {
    $.ajax({
        url: ProcessData,
        success: function(json) {
            var result = json;
            $(".wall").append(result[0].Nik);
        }
    })    
})