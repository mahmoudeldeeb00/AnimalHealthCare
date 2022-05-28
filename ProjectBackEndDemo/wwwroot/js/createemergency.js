// form variables


let a = localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`





let emergencyInput = `.user-form form div.name-section div.input-section input`;
let emergencyIcon = `.user-form form div.name-section div.input-section .input-icon svg`;
let descipInput = `.user-form form div.desrip-section div.input-section textarea`;
let desripIcon = `.user-form form div.desrip-section div.input-section .input-icon svg`;
let dealInput = `.user-form form div.deal-section div.input-section textarea`;
let dealIcon = `.user-form form div.deal-section div.input-section .input-icon svg`;
let petInput = `.user-form form div.pet-section div.input-section select.emergency-pet`;
let petIcon = `.user-form form div.pet-section div.input-section .select-icon svg`;
let medicineInput = `.user-form form div.medicine-section div.input-section select.emergency-medicine`;
let medicineIcon = `.user-form form div.medicine-section div.input-section .select-icon svg`;
let symptomInput = `.user-form form div.symptom-section div.input-section select.emergency-symptom`;
let symptomIcon = `.user-form form div.symptom-section div.input-section .select-icon svg`;
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
            $(d).after(`<link rel="stylesheet" href="/css/createemergency-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/createemergency-ar.css" class="style-ar" />`);
    }
});
// Toggle name icon by focusing
$(emergencyInput).on({
    focus: function() {
        $(emergencyIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(emergencyIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle desription icon by focusing
$(descipInput).on({
    focus: function() {
        $(desripIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(desripIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});
// Toggle deal icon by focusing
$(dealInput).on({
    focus: function() {
        $(dealIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(dealIcon).removeClass("fa-file-signature").addClass("fa-file");
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
// Toggle medicine icon by focusing
$(medicineInput).on({
    focus: function() {
        $(medicineIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(medicineIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});
// Toggle symptom icon by focusing
$(symptomInput).on({
    focus: function() {
        $(symptomIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function() {
        $(symptomIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});
// Toggle keyword icon by focusing
$(keywordInput).on({
    focus: function() {
        $(keywordIcon).removeClass("fa-file").addClass("fa-file-signature");
    },
    blur: function() {
        $(keywordIcon).removeClass("fa-file-signature").addClass("fa-file");
    }
});