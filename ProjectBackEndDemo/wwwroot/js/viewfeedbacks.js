// feedback variables



let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`


let feedbacks = `.feedbacks-section .container .feedback-box`;
let feedbacksCounter = $(feedbacks).length;
let feedbackBtn = `.feedbacks-section span.feedback-link`;
let feedbackBtntxt = `.feedbacks-section span.feedback-link span`;
let feedbackArrow = `.feedbacks-section span.feedback-link svg`;
// Start check Localstorage
// page language value
if (a !== null) {
    if (a == "en") {
        if (!$(b).hasClass("active")) {
            $(b).siblings().removeClass("active");
            $(b).addClass("active");
            $("html").attr("lang", "en");
            $("body").attr("translate", "no");
            if ($(e).attr("href") != undefined) {
                $(e).remove();
            }
        }
    } else if (a == "ar") {
        if (!$(c).hasClass("active")) {
            $(c).siblings().removeClass("active");
            $(c).addClass("active");
            $("html").attr("lang", "ar");
            $("body").attr("translate", "yes");
            $(d).after(`<link rel="stylesheet" href="/css/viewfeedbacks-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// Check and edit feedbacks
if (feedbacksCounter > 4) {
    for (let i = feedbacksCounter - 1; i > 3; i--) {
        $(feedbacks)[i].classList.add("hide");
    }
} else {
    $(feedbackBtn).hide();
}
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/viewfeedbacks-ar.css" class="style-ar" />`);
    }
});
// Click on view more/less btn
$(feedbackBtn).on("click", function() {
    if ($(feedbackBtn).hasClass("more")) {
        for (let i = 3; i < feedbacksCounter; i++) {
            $(feedbacks)[i].classList.remove("hide");
        }
        $(feedbackArrow).removeClass("fa-angles-down").addClass("fa-angles-up");
        $(feedbackBtntxt).text("View Less");
        $(feedbackBtn).removeClass("more").addClass("less");
    } else if ($(feedbackBtn).hasClass("less")) {
        for (let i = feedbacksCounter - 1; i > 3; i--) {
            $(feedbacks)[i].classList.add("hide");
        }
        $(feedbackArrow).removeClass("fa-angles-up").addClass("fa-angles-down");
        $(feedbackBtntxt).text("View More");
        $(feedbackBtn).removeClass("less").addClass("more");
    }
});