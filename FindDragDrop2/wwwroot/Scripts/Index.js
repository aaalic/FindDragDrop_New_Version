$(document).ready(function () {
    $(document.body).hide();

    $.ajax({
        url: "/Home/GetItems",
        type: "GET",
        success: function (result) {
            $("#myPartialContainer").html(result);

            success: $(function () {
                $("#dragFirst").draggable({
                    revert: "invalid",
                    scope: "first"
                });

                $("#dropFirst").droppable({
                    scope: "first",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });


                $("#dragSecond").draggable({
                    revert: "invalid",
                    scope: "second"
                });

                $("#dropSecond").droppable({
                    scope: "second",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragThird").draggable({
                    revert: "invalid",
                    scope: "third"
                });

                $("#dropThird").droppable({
                    scope: "third",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragFourth").draggable({
                    revert: "invalid",
                    scope: "fourth"
                });

                $("#dropFourth").droppable({
                    scope: "fourth",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragFifth").draggable({
                    revert: "invalid",
                    scope: "fifth"
                });

                $("#dropFifth").droppable({
                    scope: "fifth",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragSixth").draggable({
                    revert: "invalid",
                    scope: "sixth"
                });

                $("#dropSixth").droppable({
                    scope: "sixth",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragSeventh").draggable({
                    revert: "invalid",
                    scope: "seventh"
                });

                $("#dropSeventh").droppable({
                    scope: "seventh",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragEigth").draggable({
                    revert: "invalid",
                    scope: "eigth"
                });

                $("#dropEigth").droppable({
                    scope: "eigth",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });

                $("#dragNinth").draggable({
                    revert: "invalid",
                    scope: "ninth"
                });

                $("#dropNinth").droppable({
                    scope: "ninth",
                    drop: function (event, ui) {
                        $(this).addClass("wordDone");
                        checkGameEnded();
                    },
                    out: function (event, ui) {
                        $(this).css("background-color", "")
                    }
                });


            });

        }



    });

    $(document.body).show();



});

function checkGameEnded() {
    var wordCorrect = $("td.wordDone").length;

    var totalWords = $("td.droppable").length;

    console.log("wordCorrect: " + wordCorrect + " totalWords: " + totalWords);

    if (wordCorrect === totalWords) {
       
        alert("YOU WIN!!");
    }
}









