// form variables
let nameInput = `.user-form form div.name-section div.input-section input.user-name`;
let nameIcon = `.user-form form div.name-section div.input-section .name-icon svg`;
let emailInput = `.user-form form div.site-email div.input-section input.user-email`;
let emailIcon = `.user-form form div.site-email div.input-section .email-icon svg`;
let gmailInput = `.user-form form div.gmail-email div.input-section input.user-email`;
let gmailIcon = `.user-form form div.gmail-email div.input-section .email-icon svg`;
let phoneInput = `.user-form form div.phone-section div.input-section input.user-phone`;
let phoneIcon = `.user-form form div.phone-section div.input-section .phone-icon svg`;
let birthInput = `.user-form form div.birthday-section div.input-section input.user-birthday`;
let birthIcon = `.user-form form div.birthday-section div.input-section .birthday-icon svg`;
let petInput = `.user-form form div.pet-section div.input-section select.user-pet`;
let petIcon = `.user-form form div.pet-section div.input-section .select-icon svg`;
let sensorInput = `.user-form form div.sensor-section div.input-section select.pet-sensor`;
let sensorIcon = `.user-form form div.sensor-section div.input-section .select-icon svg`;
// Toggle name icon by focusing
$(nameInput).on({
    focus: function () {
        $(nameIcon).removeClass("fa-user").addClass("fa-user-pen");
    },
    blur: function () {
        $(nameIcon).removeClass("fa-user-pen").addClass("fa-user");
    }
});
// Toggle email icon by focusing
$(emailInput).on({
    focus: function () {
        $(emailIcon).removeClass("fa-envelope").addClass("fa-envelope-open");
    },
    blur: function () {
        $(emailIcon).removeClass("fa-envelope-open").addClass("fa-envelope");
    }
});
// Toggle gmail icon by focusing
$(gmailInput).on({
    focus: function () {
        $(gmailIcon).removeClass("fa-envelope").addClass("fa-envelope-open");
    },
    blur: function () {
        $(gmailIcon).removeClass("fa-envelope-open").addClass("fa-envelope");
    }
});
// Toggle phone icon by focusing
$(phoneInput).on({
    focus: function () {
        $(phoneIcon).removeClass("fa-phone").addClass("fa-tty");
    },
    blur: function () {
        $(phoneIcon).removeClass("fa-tty").addClass("fa-phone");
    }
});
// Toggle birthday icon by focusing
$(birthInput).on({
    focus: function () {
        $(birthIcon).removeClass("fa-calendar").addClass("fa-calendar-days");
    },
    blur: function () {
        $(birthIcon).removeClass("fa-calendar-days").addClass("fa-calendar");
    }
});
// Toggle pet icon by focusing
$(petInput).on({
    focus: function () {
        $(petIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function () {
        $(petIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});
// Toggle sensor icon by focusing
$(sensorInput).on({
    focus: function () {
        $(sensorIcon).removeClass("fa-box").addClass("fa-box-open");
    },
    blur: function () {
        $(sensorIcon).removeClass("fa-box-open").addClass("fa-box");
    }
});