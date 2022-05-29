$(document).ready(function () {


    function getNotification() {
        var res = "<ul class='notification-list'>";
        $.ajax({
            url: "/notification/getNotification",
            method: "GET",
            success: function (result) {
                if (result.length == 0) {
                    $("#notificationCount").html("");
                    $("#notificationCount").hide();
                }
                else {
                    $("#notificationCount").html(result.length);
                    $.each(result, function (i, e) {

                        res = res + "<li class='notification-box' ><div class='box-content'><span class='notifi-text' >" + e.text + "</span> <span class='notifi-time'>" + e.time + "</span></div><div class='box-links'> " + "<a href='" + e.UrlReference + "'> View the case " + " </a> " + " <a data-id='" + e.id + "'  class='marknotificationasread text-primary'>Mark as read</a></div > </li>";
                    });
                    res = res + " <br> <a class='' href='/Notification/GetAllNotification'>Notifications history </a>" + "</ul>";
                    $("#notification-content").html(res);
                    r()
                }
            },
            error: function (error) {
                console.log(error);
            }
        });

    }
    function r() {
        $(".marknotificationasread").on('click', function (e) {

            var target = e.target;
            console.log(target.parentElement.parentElement)
            var id = $(target).data('id');
            readNotification(id, target);
        })
    }



    function readNotification(id, target) {
        $.ajax({
            url: "/Notification/ReadNotification",
            method: "GET",
            data: { notificationId: id },
            success: function (result) {
                getNotification();
                var litarget = target.parentElement.parentElement;
                $(litarget).fadeOut('slow');
            },
            error: function (error) {
                console.log(error);
            }
        })
    }
    ;
    function readAllNotification() {
        console.log("clicked")
        $.ajax({
            url: "/Notification/ReadAllNotification",
            method: "Post",        
            success: function () {
                getNotification();
            },
            error: function (error) {
                console.log(error);
            }
        })
    }
    ;
    $("#readAllNotification").on("click", readAllNotification);

    function GetRandomIdNotification() {
        $.ajax({
            url: "/Sensor/SSensor/GetRandomSensorId",
            method: "POST",
            success: function (result) {
             
                createautonotification(result);
                changeCurrentMonitoring(result);
            },
            error: function (error) {
                console.log("Use Might Not Sign In ");
            }
        })
    }
    function createautonotification(e) {
        $.ajax({
            url: "/Notification/CreateAutoNotification",
            data: { id: e },
            method: "POST",
            success: function () {
            }
        })
    }


    function changeCurrentMonitoring(e) {
        $.ajax({
            url: "/Sensor/SSensor/ChangeLastMonitoring",
            method: "POST",
            data: { ID : e},
            success: function (result) {
                               
            },
            error: function (error) {
                console.log("Use Might Not Sign In ");
            }
        })
    }



    "use strict";
    var connection = new signalR.HubConnectionBuilder().withUrl("/signalServer").build();
    connection.start();

    connection.on('displayNotification', function () {
        getNotification();
    });
    ////////// use functions 


  //  GetRandomIdNotification();

    getNotification();
    r();

    
   //setTimeout(GetRandomIdNotification, 5000);


  


});
