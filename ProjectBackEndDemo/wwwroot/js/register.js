
// form variables
let nameInput = `.user-form form div.name-section input.user-name`;
let nameIcon = `.user-form form div.name-section .name-icon svg`;
let emailInput = `.user-form form div.email-section input.user-email`;
let emailIcon = `.user-form form div.email-section .email-icon svg`;
let passInputOne = `.user-form form div.pass-original input.user-password`;
let passIconOne = `.user-form form div.pass-original .show-password`;
let passIconSvgOne = `.user-form form div.pass-original .show-password svg`;
let passInputTwo = `.user-form form div.pass-confirm input.user-password`;
let passIconTwo = `.user-form form div.pass-confirm .show-password`;
let passIconSvgTwo = `.user-form form div.pass-confirm .show-password svg`;

// Toggle name icon by focusing
$(nameInput).on({
    focus: function() {
        $(nameIcon).removeClass("fa-user").addClass("fa-user-pen");
    },
    blur: function() {
        $(nameIcon).removeClass("fa-user-pen").addClass("fa-user");
    }
});
// Toggle email icon by focusing
$(emailInput).on({
    focus: function() {
        $(emailIcon).removeClass("fa-envelope").addClass("fa-envelope-open");
    },
    blur: function() {
        $(emailIcon).removeClass("fa-envelope-open").addClass("fa-envelope");
    }
});
// Toggle original password value visablity
$(passIconOne).on("click", function() {
    if ($(passInputOne).attr("type") == "password") {
        $(passInputOne).attr("type", "text");
        $(passIconSvgOne).removeClass("fa-eye-slash").addClass("fa-eye");
        $(passIconSvgOne).attr("title", "Hide password");
    } else if ($(passInputOne).attr("type") == "text") {
        $(passInputOne).attr("type", "password");
        $(passIconSvgOne).removeClass("fa-eye").addClass("fa-eye-slash");
        $(passIconSvgOne).attr("title", "Show password");
    }
});
// Toggle confirmed password value visablity
$(passIconTwo).on("click", function() {
    if ($(passInputTwo).attr("type") == "password") {
        $(passInputTwo).attr("type", "text");
        $(passIconSvgTwo).removeClass("fa-eye-slash").addClass("fa-eye");
        $(passIconSvgTwo).attr("title", "Hide password");
    } else if ($(passInputTwo).attr("type") == "text") {
        $(passInputTwo).attr("type", "password");
        $(passIconSvgTwo).removeClass("fa-eye").addClass("fa-eye-slash");
        $(passIconSvgTwo).attr("title", "Show password");
    }
});