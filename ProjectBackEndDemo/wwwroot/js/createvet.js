// form variables



let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`

let nameInput = `.user-form form div.name-section div.input-section input`;
let nameIcon = `.user-form form div.name-section div.input-section .input-icon svg`;
let specialtyInput = `.user-form form div.specialty-section div.input-section input`;
let specialtyIcon = `.user-form form div.specialty-section div.input-section .input-icon svg`;
let gmailInput = `.user-form form div.gmail-section div.input-section input`;
let gmailIcon = `.user-form form div.gmail-section div.input-section .input-icon svg`;
let phoneInput = `.user-form form div.phone-section div.input-section input`;
let phoneIcon = `.user-form form div.phone-section div.input-section .input-icon svg`;
let birthInput = `.user-form form div.birthday-section div.input-section input.user-birthday`;
let birthIcon = `.user-form form div.birthday-section div.input-section .birthday-icon svg`;
let addressInput = `.user-form form div.address-section div.input-section select.user-address`;
let addressIcon = `.user-form form div.address-section div.input-section .select-icon svg`;
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
            $(d).after(`<link rel="stylesheet" href="/css/createvet-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/createvet-ar.css" class="style-ar" />`);
    }
});
// Toggle name icon by focusing
$(nameInput).on({
    focus: function() {
        $(nameIcon).removeClass("fa-user").addClass("fa-user-pen");
    },
    blur: function() {
        $(nameIcon).removeClass("fa-user-pen").addClass("fa-user");
    }
});
// Toggle specialty icon by focusing
$(specialtyInput).on({
    focus: function() {
        $(specialtyIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(specialtyIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle gmail icon by focusing
$(gmailInput).on({
    focus: function() {
        $(gmailIcon).removeClass("fa-envelope").addClass("fa-envelope-open");
    },
    blur: function() {
        $(gmailIcon).removeClass("fa-envelope-open").addClass("fa-envelope");
    }
});
// Toggle phone icon by focusing
$(phoneInput).on({
    focus: function() {
        $(phoneIcon).removeClass("fa-phone").addClass("fa-tty");
    },
    blur: function() {
        $(phoneIcon).removeClass("fa-tty").addClass("fa-phone");
    }
});
// Toggle birthday icon by focusing
$(birthInput).on({
    focus: function() {
        $(birthIcon).removeClass("fa-calendar").addClass("fa-calendar-days");
    },
    blur: function() {
        $(birthIcon).removeClass("fa-calendar-days").addClass("fa-calendar");
    }
});
// Toggle pet icon by focusing
$(addressInput).on({
    focus: function() {
        $(addressIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(addressIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});