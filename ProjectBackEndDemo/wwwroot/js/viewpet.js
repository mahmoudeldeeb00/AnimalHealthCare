// Start check Localstorage
// page language value


let saveLanguagee = localStorage.getItem("page-language");
let langEnglishe = `.option .lang-option .lang-box > a.english`;
let langArabicc = `.option .lang-option .lang-box > a.arabic`;
let englishStylee = `link.style-en`;
let englishStylee = `link.style-ar`


if (saveLanguagee !== null) {
    if (saveLanguagee == "en") {
        if (!$(langEnglishe).hasClass("active")) {
            $(langEnglishe).siblings().removeClass("active");
            $(langEnglishe).addClass("active");
            $("html").attr("lang", "en");
            $("body").attr("translate", "no");
            if ($(englishStylee).attr("href") != undefined) {
                $(englishStylee).remove();
            }
        }
    } else if (saveLanguagee == "ar") {
        if (!$(langArabicc).hasClass("active")) {
            $(langArabicc).siblings().removeClass("active");
            $(langArabicc).addClass("active");
            $("html").attr("lang", "ar");
            $("body").attr("translate", "yes");
            $(englishStylee).after(`<link rel="stylesheet" href="/css/viewpet-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(langArabicc).on("click", function(e) {
    if (!$(langArabicc).hasClass("active")) {
        $(englishStylee).after(`<link rel="stylesheet" href="/css/viewpet-ar.css" class="style-ar" />`);
    }
});