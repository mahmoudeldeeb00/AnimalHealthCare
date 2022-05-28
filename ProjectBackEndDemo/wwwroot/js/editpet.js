// form variables
let petInput = `.user-form form div.pet-section div.input-section select`;
let petIcon = `.user-form form div.pet-section div.input-section .select-icon svg`;
let nameInput = `.user-form form div.name-section div.input-section input`;
let nameIcon = `.user-form form div.name-section div.input-section .input-icon svg`;
let genderInput = `.user-form form div.gender-section div.input-section select`;
let genderIcon = `.user-form form div.gender-section div.input-section .select-icon svg`;
let birthInput = `.user-form form div.birthday-section div.input-section input`;
let birthIcon = `.user-form form div.birthday-section div.input-section .birthday-icon svg`;
let sensorInput = `.user-form form div.sensor-section div.input-section select`;
let sensorIcon = `.user-form form div.sensor-section div.input-section .select-icon svg`;

let petsaveLanuage = localStorage.getItem("page-language");
let petlangEnglish = `.option .lang-option .lang-box > a.english`;
let petlangArabic = `.option .lang-option .lang-box > a.arabic`;
let petenglishStyle = `link.style-en`;
let petarabicstyle = `link.style-ar`;
// End Variables
// Start check Localstorage
// page language value
if (petsaveLanuage !== null) {
    if (petsaveLanuage == "en") {
        if (!$(petlangEnglish).hasClass("active")) {
            $(petlangEnglish).siblings().removeClass("active");
            $(petlangEnglish).addClass("active");
            $("html").attr("lang", "en");
            $("body").attr("translate", "no");
            if ($(petarabicstyle).attr("href") != undefined) {
                $(petarabicstyle).remove();
            }
        }
    } else if (petsaveLanuage == "ar") {
        if (!$(petlangArabic).hasClass("active")) {
            $(petlangArabic).siblings().removeClass("active");
            $(petlangArabic).addClass("active");
            $("html").attr("lang", "ar");
            $("body").attr("translate", "yes");
            $(petenglishStyle).after(`<link rel="stylesheet" href="css/editpet-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(petlangArabic).on("click", function(e) {
    if (!$(petlangArabic).hasClass("active")) {
        $(petenglishStyle).after(`<link rel="stylesheet" href="css/editpet-ar.css" class="style-ar" />`);
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
// Toggle name icon by focusing
$(nameInput).on({
    focus: function() {
        $(nameIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(nameIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle gender icon by focusing
$(genderInput).on({
    focus: function() {
        $(genderIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(genderIcon).removeClass("fa-box-open").addClass("fa-box");
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
// Toggle sensor icon by focusing
$(sensorInput).on({
    focus: function() {
        $(sensorIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(sensorIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});