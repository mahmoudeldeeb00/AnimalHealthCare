// Pets section variables







let a= localStorage.getItem("page-language");
let b = `.option .lang-option .lang-box > a.english`;
let c = `.option .lang-option .lang-box > a.arabic`;
let d = `link.style-en`;
let e = `link.style-ar`






let petBoxes = Array.from(document.querySelectorAll(`.emergency .container .emergency-pet .pet-box`));
let selectBox = $(`#selectPet`);
// emergency variables
let emergencies = `.emergency .container.emergency-section .emergency-box`;
let emergenciesCounter = $(emergencies).length;
let emergencyBtn = `.emergency span.emergency-link`;
let emergencyBtntxt = `.emergency span.emergency-link span`;
let emergencyArrow = `.emergency span.emergency-link svg`;
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
            $(d).after(`<link rel="stylesheet" href="/css/viewemergencies-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// Check and edit emergencies
if (emergenciesCounter > 4) {
    for (let i = emergenciesCounter - 1; i > 3; i--) {
        $(emergencies)[i].classList.add("hide");
    }
} else {
    $(emergencyBtn).hide();
}
// Check Pet option value
petBoxes.forEach(pet => {
    if (pet.classList.contains("active")) {
        $(selectBox).val(pet.dataset.value);
    }
});

// click on arabic btn
$(c).on("click", function(e) {
    if (!$(c).hasClass("active")) {
        $(d).after(`<link rel="stylesheet" href="/css/viewemergencies-ar.css" class="style-ar" />`);
    }
});
// Clicking on pet img
petBoxes.forEach(pet => {
    pet.addEventListener("click", () => {
        petBoxes.forEach(icon => {
            if (icon.classList.contains("active")) {
                icon.classList.remove("active");
            }
        });
        pet.classList.add("active");
        $(selectBox).val(pet.dataset.value).change();
            
    });
});
// Click on view more/less btn
$(emergencyBtn).on("click", function() {
    if ($(emergencyBtn).hasClass("more")) {
        for (let i = 3; i < emergenciesCounter; i++) {
            $(emergencies)[i].classList.remove("hide");
        }
        $(emergencyArrow).removeClass("fa-angles-down").addClass("fa-angles-up");
        $(emergencyBtntxt).text("View Less");
        $(emergencyBtn).removeClass("more").addClass("less");
    } else if ($(emergencyBtn).hasClass("less")) {
        for (let i = emergenciesCounter - 1; i > 3; i--) {
            $(emergencies)[i].classList.add("hide");
        }
        $(emergencyArrow).removeClass("fa-angles-up").addClass("fa-angles-down");
        $(emergencyBtntxt).text("View More");
        $(emergencyBtn).removeClass("less").addClass("more");
    }
});