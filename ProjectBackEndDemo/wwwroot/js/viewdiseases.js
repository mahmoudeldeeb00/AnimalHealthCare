// disease variables
let diseases = `.disease-section .container .disease-box`;
let diseasesCounter = $(diseases).length;
let diseaseBtn = `.disease-section span.disease-link`;
let diseaseBtntxt = `.disease-section span.disease-link span`;
let diseaseArrow = `.disease-section span.disease-link svg`;


let saveLanguagee = localStorage.getItem("page-language");
let langEnglishh = `.option .lang-option .lang-box > a.english`;
let langArabicc = `.option .lang-option .lang-box > a.arabic`;
let englishStylee = `link.style-en`;
let arabicstylee = `link.style-ar`
// End Variables
// Start check Localstorage
// page language value
if (saveLanguagee !== null) {
    if (saveLanguagee == "en") {
        if (!$(langEnglishh).hasClass("active")) {
            $(langEnglishh).siblings().removeClass("active");
            $(langEnglishh).addClass("active");
            $("html").attr("lang", "en");
            $("body").attr("translate", "no");
            if ($(arabicstylee).attr("href") != undefined) {
                $(arabicstylee).remove();
            }
        }
    } else if (saveLanguagee == "ar") {
        if (!$(langArabicc).hasClass("active")) {
            $(langArabicc).siblings().removeClass("active");
            $(langArabicc).addClass("active");
            $("html").attr("lang", "ar");
            $("body").attr("translate", "yes");
            $(englishStylee).after(`<link rel="stylesheet" href="/css/viewdiseases-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// Check and edit diseases
if (diseasesCounter > 4) {
    for (let i = diseasesCounter - 1; i > 3; i--) {
        $(diseases)[i].classList.add("hide");
    }
} else {
    $(diseaseBtn).hide();
}
// click on arabic btn
$(langArabicc).on("click", function(e) {
    if (!$(langArabicc).hasClass("active")) {
        $(englishStylee).after(`<link rel="stylesheet" href="/css/viewdiseases-ar.css" class="style-ar" />`);
    }
});
// Click on view more/less btn
$(diseaseBtn).on("click", function() {
    if ($(diseaseBtn).hasClass("more")) {
        for (let i = 3; i < diseasesCounter; i++) {
            $(diseases)[i].classList.remove("hide");
        }
        $(diseaseArrow).removeClass("fa-angles-down").addClass("fa-angles-up");
        $(diseaseBtntxt).text("View Less");
        $(diseaseBtn).removeClass("more").addClass("less");
    } else if ($(diseaseBtn).hasClass("less")) {
        for (let i = diseasesCounter - 1; i > 3; i--) {
            $(diseases)[i].classList.add("hide");
        }
        $(diseaseArrow).removeClass("fa-angles-up").addClass("fa-angles-down");
        $(diseaseBtntxt).text("View More");
        $(diseaseBtn).removeClass("less").addClass("more");
    }
});