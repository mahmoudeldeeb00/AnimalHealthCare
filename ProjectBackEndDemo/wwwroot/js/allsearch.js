// search variables

let saveLanguageee = localStorage.getItem("page-language");
let langEnglishh = `.option .lang-option .lang-box > a.english`;
let langArabicc = `.option .lang-option .lang-box > a.arabic`;
let englishStylee = `link.style-en`;
let arabicstylee = `link.style-ar`

let filterBtn = `.search-section .container .search-filter span`;
let searchBoxes = `.search-section .container .search-box`;
// End Variables
// Start check Localstorage
// page language value
if (saveLanguageee !== null) {
    if (saveLanguageee == "en") {
        if (!$(langEnglishh).hasClass("active")) {
            $(langEnglishh).siblings().removeClass("active");
            $(langEnglishh).addClass("active");
            $("html").attr("lang", "en");
            $("body").attr("translate", "no");
            if ($(arabicstylee).attr("href") != undefined) {
                $(arabicstylee).remove();
            }
        }
    } else if (saveLanguageee == "ar") {
        if (!$(langArabicc).hasClass("active")) {
            $(langArabicc).siblings().removeClass("active");
            $(langArabicc).addClass("active");
            $("html").attr("lang", "ar");
            $("body").attr("translate", "yes");
            $(englishStylee).after(`<link rel="stylesheet" href="/css/allsearch-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(langArabicc).on("click", function(e) {
    if (!$(langArabicc).hasClass("active")) {
        $(englishStylee).after(`<link rel="stylesheet" href="/css/allsearch-ar.css" class="style-ar" />`);
    }
});
// Click search filter button
$(filterBtn).on("click", function() {
    if (!$(this).hasClass("active")) {
        $(this).addClass("active");
        if ($(this).siblings().hasClass("active")) {
            $(this).siblings().removeClass("active")
        }
        let filterVal = $(this).attr("data-target");
        $.each($(searchBoxes), function(index) {
            if (!$(searchBoxes)[index].classList.contains(filterVal)) {
                $(searchBoxes)[index].classList.add("hide");
            } else {
                if ($(searchBoxes)[index].classList.contains("hide")) {
                    $(searchBoxes)[index].classList.remove("hide");
                }
            }
        });
    }
});