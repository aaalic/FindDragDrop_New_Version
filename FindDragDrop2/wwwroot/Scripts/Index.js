$(document).ready(function () {

    $.ajax({
        url: "/Home/GetObjects",
        type: "GET",
        success: function (result) {
            $("#myPartialContainer").html(result);
                
                success: $(function () {
                    $("#dragFirst").draggable({
                        scope: "first"
                    });

                    $("#dropFirst").droppable({
                        scope: "first",
                        drop: function (event, ui) {
                            $(this).css("background-color", "SeaGreen")
                        },
                        out: function (event, ui) {
                            $(this).css("background-color", "")
                        }
                    });
                });
        }

    });


});

            

            //    $("#dragSecond").draggable({
            //        scope: "second"
            //    });

                //$("#dropSecond").droppable({
                //    scope: "second",
                //    drop: function (event, ui) {
                //        $(this).css("background-color", "SeaGreen")
                //    },
                //    out: function (event, ui) {
                //        $(this).css("background-color", "")
                //    }
                //});

                //$("#dragThird").draggable({
                //    scope: "third"
                //});

                //$("#dropThird").droppable({
                //    scope: "third",
                //    drop: function (event, ui) {
                //        $(this).css("background-color", "SeaGreen")
                //    },
                //    out: function (event, ui) {
                //        $(this).css("background-color", "")
                //    }
                //});

          




