// form variables



let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`


let nameInput = `.user-form form div.select-section div.name-section select.user-name`;
let nameIcon = `.user-form form div.select-section div.name-section .select-icon svg`;
let roleInput = `.user-form form div.select-section div.role-section select.user-role`;
let roleIcon = `.user-form form div.select-section div.role-section .select-icon svg`;
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
            $(d).after(`<link rel="stylesheet" href="/css/signuserstoroles-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/signuserstoroles-ar.css" class="style-ar" />`);
    }
});
// Toggle pet icon by focusing
$(nameInput).on({
    focus: function() {
        $(nameIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(nameIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});
// Toggle sensor icon by focusing
$(roleInput).on({
    focus: function() {
        $(roleIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(roleIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});