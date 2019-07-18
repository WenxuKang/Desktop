/*  JavaScript 6th Edition
    Chapter 10
    Hands-on Project 10-3

    Author: 
    Date:   

    Filename: script.js
*/

"use strict";
var waitForUser;
function setUpPage() {
    var buttons = document.querySelectorAll("#cities div");
    for (var i = 0; i < buttons.length; i++) {
        if (buttons[i].addEventListener) {
            buttons[i].addEventListener("click", createMap, false);
        } else if (buttons[i].attachEvent) {
            buttons[i].attachEvent("onclick", createMap);
        }
    }
}

function geoTest() {
    waitForUser = setTimeout(fail, 10000);
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(createMap, fail,
            { timeout: 10000 });
    } else {
        fail();
    }
}

function createMap(position) {
    var Lat;
    var Lng;
    clearTimeout(waitForUser);

    if (position.coords) {
        Lat = position.coords.latitude;
        Lng = position.coords.longitude;
    } else {
        var city = this.innerHTML;
        if (city === "Beijing") {
            //Beijing 39.9710186,116.2202938
            Lat = 39.9710186;
            Lng = 116.2202938;
        }
        if (city === "Paris") {
            //Paris 48.8587741,2.2069729
            Lat = 48.8587741;
            Lng = 2.2069729;
        }
        if (city === "Rio de Janeiro") {
            Lat = -22.9133954;
            Lng = -43.2007101;
        }
        // Washington 38.906872, -77.035189
        document.getElementById("caption").innerHTML = city;
    }

    var mapOptions = {
        center: new google.maps.LatLng(Lat, Lng),
        zoom: 10
    };
    new google.maps.Map(document.getElementById("map"), mapOptions);
}

function fail() {
    document.getElementById("map").innerHTML = "Unable to access your current location.";
}

if (window.addEventListener) {
    window.addEventListener("load", setUpPage, false);
} else if (window.attachEvent) {
    window.attachEvent("onload", setUpPage);
}
