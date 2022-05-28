// form variables

let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`

let petInput = `.user-form form div.select-section div.input-section select.pet-name`;
let petIcon = `.user-form form div.select-section div.input-section .select-icon svg`;
let cleanInput = `.user-form form div.cleanliness-section div.input-section textarea`;
let cleanIcon = `.user-form form div.cleanliness-section div.input-section .text-icon svg`;
let careInput = `.user-form form div.care-section div.input-section textarea`;
let careIcon = `.user-form form div.care-section div.input-section .text-icon svg`;
let matingInput = `.user-form form div.mating-section div.input-section textarea`;
let matingIcon = `.user-form form div.mating-section div.input-section .text-icon svg`;
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
            $(d).after(`<link rel="stylesheet" href="/css/createlifestyle-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/createlifestyle-ar.css" class="style-ar" />`);
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
// Toggle cleanliness icon by focusing
$(cleanInput).on({
    focus: function() {
        $(cleanIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(cleanIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle care icon by focusing
$(careInput).on({
    focus: function() {
        $(careIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(careIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle mating icon by focusing
$(matingInput).on({
    focus: function() {
        $(matingIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(matingIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});