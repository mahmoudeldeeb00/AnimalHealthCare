// Pets section variables
let petBoxes = Array.from(document.querySelectorAll(`.lifestyle .container .lifestyle-pet .pet-box`));
let selectBox = `.lifestyle select`;
let LifeStylelangEnglish = `.option .lang-option .lang-box > a.english`;
let LifeStylelangArabic = `.option .lang-option .lang-box > a.arabic`;
let LifeStyleenglishStyle = `link.style-en`;
let LifeStylearabicStyle = `link.style-ar`;
let LifeStylesaveLanguage = localStorage.getItem("page-language");


// End Variables
// Start check Localstorage
// page language value
if (LifeStylesaveLanguage !== null) {
    if (LifeStylesaveLanguage == "en") {
        if (!$(LifeStylelangEnglish).hasClass("active")) {
            $(LifeStylelangEnglish).siblings().removeClass("active");
            $(LifeStylelangEnglish).addClass("active");
            $("html").attr("lang", "en");
            $("body").attr("translate", "no");
            if ($(LifeStylearabicStyle).attr("href") != undefined) {
                $(LifeStylearabicStyle).remove();
            }
        }
    } else if (LifeStylesaveLanguage == "ar") {
        if (!$(LifeStylelangArabic).hasClass("active")) {
            $(LifeStylelangArabic).siblings().removeClass("active");
            $(LifeStylelangArabic).addClass("active");
            $("html").attr("lang", "ar");
            $("body").attr("translate", "yes");
            $(LifeStylearabicStyle).after(`<link rel="stylesheet" href="css/lifestyle-ar.css" class="style-ar" />`);
        }
    }
}
// End check Localstorage
// Check Pet option value
petBoxes.forEach(pet => {
    if (pet.classList.contains("active")) {
        $(selectBox).val(pet.dataset.value);
    }
});
// click on arabic btn
$(LifeStylelangArabic).on("click", function(e) {
    if (!$(LifeStylelangArabic).hasClass("active")) {
        $(LifeStyleenglishStyle).after(`<link rel="stylesheet" href="css/lifestyle-ar.css" class="style-ar" />`);
    }
});
// Clicking on pet img
//petBoxes.forEach(pet => {
//    pet.addEventListener("click", () => {
//        petBoxes.forEach(icon => {
//            if (icon.classList.contains("active")) {
//                icon.classList.remove("active");
//            }
//        });
//        pet.classList.add("active");
//        $(selectBox).val(pet.dataset.value);
//        //change data
//        let aniID = parseInt(pet.dataset.id);
//        console.log(aniID)

//        $.ajax({
//            url: "/Care/LifeStyle/AjaxGetLifeStyleWithId",
//            method: "GET",
//            data: { Id : aniID  },
//            success: function (res) {

//                console.log(res)
//            }, error: function () {
//                console.log("unable to get data")
//            }

//        });

//    });
//});

// change data 

