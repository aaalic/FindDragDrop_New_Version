$(document).ready(function () {

    $.ajax({
        url: "/Home/GetItems",
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


                $("#dragSecond").draggable({
                    scope: "second"
                });

                $("#dropSecond").droppable({
                    scope: "second",
                    drop: function (event, ui) {
                        $(this).css("background-color", "SeaGreen")
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragThird").draggable({
                    scope: "third"
                });

                $("#dropThird").droppable({
                    scope: "third",
                    drop: function (event, ui) {
                        $(this).css("background-color", "SeaGreen")
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragFourth").draggable({
                    scope: "fourth"
                });

                $("#dropFourth").droppable({
                    scope: "fourth",
                    drop: function (event, ui) {
                        $(this).css("background-color", "SeaGreen")
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragFifth").draggable({
                    scope: "fifth"
                });

                $("#dropFifth").droppable({
                    scope: "fifth",
                    drop: function (event, ui) {
                        $(this).css("background-color", "SeaGreen")
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragSixth").draggable({
                    scope: "sixth"
                });

                $("#dropSixth").droppable({
                    scope: "sixth",
                    drop: function (event, ui) {
                        $(this).css("background-color", "SeaGreen")
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragSeventh").draggable({
                    scope: "seventh"
                });

                $("#dropSeventh").droppable({
                    scope: "seventh",
                    drop: function (event, ui) {
                        $(this).css("background-color", "SeaGreen")
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragEigth").draggable({
                    scope: "eigth"
                });

                $("#dropEigth").droppable({
                    scope: "eigth",
                    drop: function (event, ui) {
                        $(this).css("background-color", "SeaGreen")
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragNinth").draggable({
                    scope: "ninth"
                });

                $("#dropNinth").droppable({
                    scope: "ninth",
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

            


          




