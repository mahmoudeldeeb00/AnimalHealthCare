// form variables


let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`


let foodInput = `.user-form form div.food-section input.food-name`;
let foodIcon = `.user-form form div.food-section .input-icon svg`;
let descripInput = `.user-form form div.descrip-section input.food-descrip`;
let descripIcon = `.user-form form div.descrip-section .input-icon svg`;
let petInput = `.user-form form div.select-section div.input-section select`;
let petIcon = `.user-form form div.select-section div.input-section .select-icon svg`;
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
            $(d).after(`<link rel="stylesheet" href="/css/createrole-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/createrole-ar.css" class="style-ar" />`);
    }
});
// Toggle food icon by focusing
$(foodInput).on({
    focus: function() {
        $(foodIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(foodIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle description icon by focusing
$(descripInput).on({
    focus: function() {
        $(descripIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(descripIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle pet icon by focusing
$(petInput).on({
    focus: function() {
        $(petIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(petIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});