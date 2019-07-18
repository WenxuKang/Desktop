/*    JavaScript 6th Edition
 *    Chapter 5
 *    Chapter case

 *    Photo zoom
 *    Variables and functions
 *    Author: 
 *    Date:   

 *    Filename: zoom.js
 */

"use strict"; // interpret document contents in JavaScript strict mode

/* global variables */
var photoOrderArray = window.opener.photoOrder;
var figFilename = "images/IMG_0" + photoOrderArray[2] + ".jpg";

/* populate img element and create event listener */
function pageSetup() {
   document.getElementsByTagName("img")[0].src = figFilename; // assign filename to img element
   createEventListener();
}

function AddFavorite(){
    var favoritA = window.opener.favoriteArray;
    if (favoritA.length < 5) {
        favoritA.push(figFilename);
        window.opener.disFavoritPicture();
        
    }
    else {
        window.alert("The maximum of favorit pictue is 5.");
    }
}
/* close window */
function closeWin() {
   window.close();
}

/* create event listener for close button */
function createEventListener() {
    var closeWindowDiv = document.getElementsByTagName("button")[0];
    if (closeWindowDiv.addEventListener) {
        closeWindowDiv.addEventListener("click", AddFavorite, false);
    } else if (closeWindowDiv.attachEvent) {
        closeWindowDiv.attachEvent("onclick", AddFavorite);
    }

    var closeWindowDiv1 = document.getElementsByTagName("button")[1];
    if (closeWindowDiv1.addEventListener) {
        closeWindowDiv1.addEventListener("click", closeWin, false);
    } else if (closeWindowDiv1.attachEvent) {
        closeWindowDiv1.attachEvent("onclick", closeWin);
    }
}

/* add img src value and create event listener when page finishes loading */
window.onload = pageSetup;