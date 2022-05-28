// Start check Localstorage


let ThesaveLanguage = localStorage.getItem("page-language");
let langEnglishh = `.option .lang-option .lang-box > a.english`;
let langArabicc = `.option .lang-option .lang-box > a.arabic`;
let englishStylee = `link.style-en`;
let arabicstylee = `link.style-ar`

// page language value
if (ThesaveLanguage !== null) {
    if (ThesaveLanguage == "en") {
        if (!$(langEnglishh).hasClass("active")) {
            $(langEnglishh).siblings().removeClass("active");
            $(langEnglishh).addClass("active");
            $("html").attr("lang", "en");
            $("body").attr("translate", "no");
            if ($(arabicstylee).attr("href") != undefined) {
                $(arabicstylee).remove();
            }
        }
    } else if (ThesaveLanguage == "ar") {
        if (!$(langArabicc).hasClass("active")) {
            $(langArabicc).siblings().removeClass("active");
            $(langArabicc).addClass("active");
            $("html").attr("lang", "ar");
            $("body").attr("translate", "yes");
            $(englishStylee).after(`<link rel="stylesheet" href="css/aboutus-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(langArabicc).on("click", function(e) {
    if (!$(langArabicc).hasClass("active")) {
        $(englishStylee).after(`<link rel="stylesheet" href="css/aboutus-ar.css" class="style-ar" />`);
    }
});