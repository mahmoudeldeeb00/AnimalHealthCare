
// form variables
let nameInput = `.user-form form div.name-section input.user-name`;
let nameIcon = `.user-form form div.name-section .name-icon svg`;
// Toggle name icon by focusing
$(nameInput).on({
    focus: function() {
        $(nameIcon).removeClass("fa-user").addClass("fa-user-pen");
    },
    blur: function() {
        $(nameIcon).removeClass("fa-user-pen").addClass("fa-user");
    }
});