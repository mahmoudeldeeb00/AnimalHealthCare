// form variables


let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`





let nameInput = `.user-form form div.medicine-section div.input-section input`;
let nameIcon = `.user-form form div.medicine-section div.input-section .input-icon svg`;
let priceInput = `.user-form form div.price-section div.input-section input`;
let priceIcon = `.user-form form div.price-section div.input-section .input-icon svg`;
let tempInput = `.user-form form div.temp-section div.input-section input`;
let tempIcon = `.user-form form div.temp-section div.input-section .input-icon svg`;
let expirtyInput = `.user-form form div.expirty-section div.input-section input`;
let expirtyIcon = `.user-form form div.expirty-section div.input-section .input-icon svg`;
let keywordInput = `.user-form form div.keyword-section div.input-section input`;
let keywordIcon = `.user-form form div.keyword-section div.input-section .input-icon svg`;
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
            $(d).after(`<link rel="stylesheet" href="/css/createmedicine-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/createmedicine-ar.css" class="style-ar" />`);
    }
});
// Toggle name icon by focusing
$(nameInput).on({
    focus: function() {
        $(nameIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(nameIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle Price icon by focusing
$(priceInput).on({
    focus: function() {
        $(priceIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(priceIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle temperature icon by focusing
$(tempInput).on({
    focus: function() {
        $(tempIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(tempIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle expirty icon by focusing
$(expirtyInput).on({
    focus: function() {
        $(expirtyIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(expirtyIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle keywords icon by focusing
$(keywordInput).on({
    focus: function() {
        $(keywordIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(keywordIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});