// vet variables


let saveLanguagee = localStorage.getItem("page-language");
let langEnglishh = `.option .lang-option .lang-box > a.english`;
let langArabicc = `.option .lang-option .lang-box > a.arabic`;
let englishStylee = `link.style-en`;
let arabicstylee = `link.style-ar`

let vets = `.vet-section .container .vet-box`;
let vetsCounter = $(vets).length;
let vetBtn = `.vet-section span.vet-link`;
let vetBtntxt = `.vet-section span.vet-link span`;
let vetArrow = `.vet-section span.vet-link svg`;
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
            $(englishStylee).after(`<link rel="stylesheet" href="/css/allvets-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// Check and edit vets
if (vetsCounter > 4) {
    for (let i = vetsCounter - 1; i > 3; i--) {
        $(vets)[i].classList.add("hide");
    }
} else {
    $(vetBtn).hide();
}
// click on arabic btn
$(langArabicc).on("click", function(e) {
    if (!$(langArabicc).hasClass("active")) {
        $(englishStylee).after(`<link rel="stylesheet" href="/css/allvets-ar.css" class="style-ar" />`);
    }
});
// Click on view more/less btn
$(vetBtn).on("click", function() {
    if ($(vetBtn).hasClass("more")) {
        for (let i = 3; i < vetsCounter; i++) {
            $(vets)[i].classList.remove("hide");
        }
        $(vetArrow).removeClass("fa-angles-down").addClass("fa-angles-up");
        $(vetBtntxt).text("View Less");
        $(vetBtn).removeClass("more").addClass("less");
    } else if ($(vetBtn).hasClass("less")) {
        for (let i = vetsCounter - 1; i > 3; i--) {
            $(vets)[i].classList.add("hide");
        }
        $(vetArrow).removeClass("fa-angles-up").addClass("fa-angles-down");
        $(vetBtntxt).text("View More");
        $(vetBtn).removeClass("less").addClass("more");
    }
});
// Toggle full vet card by clicking
$(vets).on("click", function() {
    if (!$(this).hasClass("open")) {
        $(this).toggleClass("open");
        if ($(this).siblings().hasClass("open")) {
            $(this).siblings().removeClass("open");
        }
    }
})