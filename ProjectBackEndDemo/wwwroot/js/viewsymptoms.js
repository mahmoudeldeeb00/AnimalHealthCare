// symptom variables




let saveLanguagee = localStorage.getItem("page-language");
let langEnglishh = `.option .lang-option .lang-box > a.english`;
let langArabicc = `.option .lang-option .lang-box > a.arabic`;
let englishStylee = `link.style-en`;
let arabicstylee = `link.style-ar`


let symptoms = `.symptom-section .container .symptom-box`;
let symptomsCounter = $(symptoms).length;
let symptomBtn = `.symptom-section span.symptom-link`;
let symptomBtntxt = `.symptom-section span.symptom-link span`;
let symptomArrow = `.symptom-section span.symptom-link svg`;
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
            $(englishStylee).after(`<link rel="stylesheet" href="/css/viewsymptoms-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// Check and edit symptoms
if (symptomsCounter > 4) {
    for (let i = symptomsCounter - 1; i > 3; i--) {
        $(symptoms)[i].classList.add("hide");
    }
} else {
    $(symptomBtn).hide();
}
// click on arabic btn
$(langArabicc).on("click", function(e) {
    if (!$(langArabicc).hasClass("active")) {
        $(englishStylee).after(`<link rel="stylesheet" href="/css/viewsymptoms-ar.css" class="style-ar" />`);
    }
});
// Click on view more/less btn
$(symptomBtn).on("click", function() {
    if ($(symptomBtn).hasClass("more")) {
        for (let i = 3; i < symptomsCounter; i++) {
            $(symptoms)[i].classList.remove("hide");
        }
        $(symptomArrow).removeClass("fa-angles-down").addClass("fa-angles-up");
        $(symptomBtntxt).text("View Less");
        $(symptomBtn).removeClass("more").addClass("less");
    } else if ($(symptomBtn).hasClass("less")) {
        for (let i = symptomsCounter - 1; i > 3; i--) {
            $(symptoms)[i].classList.add("hide");
        }
        $(symptomArrow).removeClass("fa-angles-up").addClass("fa-angles-down");
        $(symptomBtntxt).text("View More");
        $(symptomBtn).removeClass("less").addClass("more");
    }
});