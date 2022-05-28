// form variables
let formSection = `.user-form`;
let emailInput = `.user-form form div.email-section input.user-email`;
let emailIcon = `.user-form form div.email-section .email-icon svg`;
let passInput = `.user-form form div.pass-section input.user-password`;
let passIcon = `.user-form form div.pass-section .show-password`;
let passIconSvg = `.user-form form div.pass-section .show-password svg`;
// Toggle email icon by focusing
$(emailInput).on({
    focus: function() {
        $(emailIcon).removeClass("fa-envelope").addClass("fa-envelope-open");
    },
    blur: function() {
        $(emailIcon).removeClass("fa-envelope-open").addClass("fa-envelope");
    }
});
// Toggle password value visablity
$(passIcon).on("click", function() {
    if ($(passInput).attr("type") == "password") {
        $(passInput).attr("type", "text");
        $(passIconSvg).removeClass("fa-eye-slash").addClass("fa-eye");
        $(passIconSvg).attr("title", "Hide password");
    } else if ($(passInput).attr("type") == "text") {
        $(passInput).attr("type", "password");
        $(passIconSvg).removeClass("fa-eye").addClass("fa-eye-slash");
        $(passIconSvg).attr("title", "Show password");
    }
});