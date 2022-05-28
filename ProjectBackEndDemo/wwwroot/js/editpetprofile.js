// form variables
let fileInput = `.user-form form div.file-section input.user-picture`;
let fileIcon = `.user-form form div.file-section .file-icon > svg`;

let customsaveLanuage = localStorage.getItem("page-language");
let customlangEnglish = `.option .lang-option .lang-box > a.english`;
let customArabic = `.option .lang-option .lang-box > a.arabic`;
let customenglishStyle = `link.style-en`;
let customarabicstyle = `link.style-ar`;

// End Variables
// Start check Localstorage
// page language value
if (customsaveLanguage !== null) {
    if (customsaveLanguage == "en") {
        if (!$(customlangEnglish).hasClass("active")) {
            $(customlangEnglish).siblings().removeClass("active");
            $(customlangEnglish).addClass("active");
            $("html").attr("lang", "en");
            $("body").attr("translate", "no");
            if ($(customarabicStyle).attr("href") != undefined) {
                $(customarabicStyle).remove();
            }
        }
    } else if (customsaveLanguage == "ar") {
        if (!$(customlangArabic).hasClass("active")) {
            $(customlangArabic).siblings().removeClass("active");
            $(customlangArabic).addClass("active");
            $("html").attr("lang", "ar");
            $("body").attr("translate", "yes");
            $(customenglishStyle).after(`<link rel="stylesheet" href="css/editpetprofile-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(customlangArabic).on("click", function(e) {
    if (!$(customlangArabic).hasClass("active")) {
        $(customlangArabic).siblings().removeClass("active");
        $(customlangArabic).addClass("active");
        $("html").attr("lang", "ar");
        $("body").attr("translate", "yes");
        $(customenglishStyle).after(`<link rel="stylesheet" href="css/editpetprofile-ar.css" class="style-ar" />`);
        localStorage.setItem("page-language", "ar");
    } else {
        e.preventDefault();
    }
});
// Toggle name icon by focusing
$(fileInput).on({
    focus: function() {
        $(fileIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(fileIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});