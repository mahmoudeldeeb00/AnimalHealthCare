// medicine variables


let saveLanguagee = localStorage.getItem("page-language");
let langEnglishh = `.option .lang-option .lang-box > a.english`;
let langArabicc = `.option .lang-option .lang-box > a.arabic`;
let englishStylee = `link.style-en`;
let arabicstylee = `link.style-ar`


let medicines = `.medicine-section .container .medicine-box`;
let medicinesCounter = $(medicines).length;
let medicineBtn = `.medicine-section span.medicine-link`;
let medicineBtntxt = `.medicine-section span.medicine-link span`;
let medicineArrow = `.medicine-section span.medicine-link svg`;
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
            $(englishStylee).after(`<link rel="stylesheet" href="/css/viewmedicines-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// Check and edit medicines
if (medicinesCounter > 4) {
    for (let i = medicinesCounter - 1; i > 3; i--) {
        $(medicines)[i].classList.add("hide");
    }
} else {
    $(medicineBtn).hide();
}
// click on arabic btn
$(langArabicc).on("click", function(e) {
    if (!$(langArabicc).hasClass("active")) {
        $(englishStylee).after(`<link rel="stylesheet" href="/css/viewmedicines-ar.css" class="style-ar" />`);
    }
});
// Click on view more/less btn
$(medicineBtn).on("click", function() {
    if ($(medicineBtn).hasClass("more")) {
        for (let i = 3; i < medicinesCounter; i++) {
            $(medicines)[i].classList.remove("hide");
        }
        $(medicineArrow).removeClass("fa-angles-down").addClass("fa-angles-up");
        $(medicineBtntxt).text("View Less");
        $(medicineBtn).removeClass("more").addClass("less");
    } else if ($(medicineBtn).hasClass("less")) {
        for (let i = medicinesCounter - 1; i > 3; i--) {
            $(medicines)[i].classList.add("hide");
        }
        $(medicineArrow).removeClass("fa-angles-up").addClass("fa-angles-down");
        $(medicineBtntxt).text("View More");
        $(medicineBtn).removeClass("less").addClass("more");
    }
});