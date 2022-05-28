// form variables



let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`






let queInput = `.user-form form div.text-section div.input-section input`;
let queIcon = `.user-form form div.text-section div.input-section .input-icon svg`;
let ansInput = `.user-form form div.area-section div.input-section textarea`;
let ansIcon = `.user-form form div.area-section div.input-section .input-icon svg`;
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
            $(d).after(`<link rel="stylesheet" href="/css/createfaq-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/createfaq-ar.css" class="style-ar" />`);
    }
});
// Toggle question icon by focusing
$(queInput).on({
    focus: function() {
        $(queIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(queIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle answere icon by focusing
$(ansInput).on({
    focus: function() {
        $(ansIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(ansIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});