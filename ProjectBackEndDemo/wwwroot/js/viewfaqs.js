// faq variables




let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`









let faqs = `.faq-section .container .faq-box`;
let faqsCounter = $(faqs).length;
let faqBtn = `.faq-section span.faq-link`;
let faqBtntxt = `.faq-section span.faq-link span`;
let faqArrow = `.faq-section span.faq-link svg`;
// End Variables
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
            $(d).after(`<link rel="stylesheet" href="/css/viewfaqs-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// Check and edit faqs
if (faqsCounter > 4) {
    for (let i = faqsCounter - 1; i > 3; i--) {
        $(faqs)[i].classList.add("hide");
    }
} else {
    $(faqBtn).hide();
}
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/viewfaqs-ar.css" class="style-ar" />`);
    }
});
// Click on view more/less btn
$(faqBtn).on("click", function() {
    if ($(faqBtn).hasClass("more")) {
        for (let i = 3; i < faqsCounter; i++) {
            $(faqs)[i].classList.remove("hide");
        }
        $(faqArrow).removeClass("fa-angles-down").addClass("fa-angles-up");
        $(faqBtntxt).text("View Less");
        $(faqBtn).removeClass("more").addClass("less");
    } else if ($(faqBtn).hasClass("less")) {
        for (let i = faqsCounter - 1; i > 3; i--) {
            $(faqs)[i].classList.add("hide");
        }
        $(faqArrow).removeClass("fa-angles-up").addClass("fa-angles-down");
        $(faqBtntxt).text("View More");
        $(faqBtn).removeClass("less").addClass("more");
    }
});