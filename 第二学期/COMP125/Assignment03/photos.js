/*    JavaScript 6th Edition
 *    Chapter 5
 *    Chapter case

 *    Photo gallery
 *    Variables and functions
 *    Author: 
 *    Date:   

 *    Filename: photos.js
 */

"use strict"; // interpret document contents in JavaScript strict mode

/* global variables */
var photoOrder = [1,2,3,4,5];
var autoAdvance = setInterval(rightAdvance,5000);
var figureCount = 3;
var favoriteArray=[] ;


function disFavoritPicture(){
    var div1 = document.getElementById("favoritArea");
    var L = div1.childNodes.length
	for(var i=0;i<L;i++)
	{
	    div1.removeChild(div1.childNodes[0] );
    }
	
	for(var i=0;i<favoriteArray.length;i++)
	{
	    
        var Image = document.createElement("img");
        Image.width = "100";
        Image.height = "50";
        Image.style.marginLeft = "10px"
        Image.name = "favorit";
        Image.id = "F" + i;
        Image.name = i;
        Image.src = favoriteArray[i];
        div1.appendChild(Image);

        var Button = document.createElement("button");
        
        Button.innerHTML = "<=delete";
        Button.id =  i;
        div1.appendChild(Button);
        Button.style.visibility = "hidden";

        var leftarrow = document.getElementById(i);
        var fpicture = document.getElementById("F" + i);
       
        

        if (fpicture.addEventListener) {
            fpicture.addEventListener("click", disPlayButton, false);
        } else if (fpicture.attachEvent) {

            fpicture.attachEvent("onclick", disPlayButton);
        }

        if (leftarrow.addEventListener) {
            leftarrow.addEventListener("click",  DelFavoritPicture, false);
        } else if (leftarrow.attachEvent) {
           
            leftarrow.attachEvent("onclick",  DelFavoritPicture);
        } 
    }
	function disPlayButton() { document.getElementById(this.name).style.visibility = "visible"; };
	function DelFavoritPicture() { favoriteArray.splice(this.id, 1); disFavoritPicture(); }
}

/* add src values to img elements based on order specified in photoOrder array */
function populateFigures() {
    var filename;
    var currentFig;
    if (figureCount === 3) {
        for (var i = 1; i < 4; i++) {
            filename = "images/IMG_0" + photoOrder[i] + "sm.jpg";
            currentFig = document.getElementsByTagName("img")[i - 1];
            currentFig.src = filename;
        }
    } else {
        for (var i = 0; i < 5; i++) {
            filename = "images/IMG_0" + photoOrder[i] + "sm.jpg";
            currentFig = document.getElementsByTagName("img")[i];
            currentFig.src = filename;
        }
    }
}

    /* stop automatic image switching and call rightAdvance() function */
    function rightArrow() {
        clearInterval(autoAdvance);
        rightAdvance();
    }

    /* shift all images one figure to the left, and change values in photoOrder array to match  */
    function rightAdvance() {
        for (var i = 0; i < 5; i++) {
            if ((photoOrder[i] + 1) === 6) {
                photoOrder[i] = 1;
            } else {
                photoOrder[i] += 1;
            }
            populateFigures();
        }
    }

    /* shift all images one figure to the right, and change values in photoOrder array to match  */
    function leftArrow() {
        clearInterval(autoAdvance);
        for (var i = 0; i < 5; i++) {
            if ((photoOrder[i] - 1) === 0) {
                photoOrder[i] = 5;
            } else {
                photoOrder[i] -= 1;
            }
            populateFigures();
        }
    }

    /* switch to 5-image layout */
    function previewFive() {
        var articleEl = document.getElementsByTagName("article")[0];
        // create figure and img elements for fifth image
        var lastFigure = document.createElement("figure");
        lastFigure.id = "fig5";
        lastFigure.style.zIndex = "5";
        lastFigure.style.position = "absolute";
        lastFigure.style.right = "45px";
        lastFigure.style.top = "67px";
        var lastImage = document.createElement("img");
        lastImage.width = "240";
        lastImage.height = "135";
        lastFigure.appendChild(lastImage);
        //   articleEl.appendChild(lastFigure);
        articleEl.insertBefore(lastFigure, document.getElementById("rightarrow"));
   
        //clone figure element for fifth image and edit to be first image
        var firstFigure = lastFigure.cloneNode(true);
        firstFigure.id = "fig1";
        firstFigure.style.right = "";
        firstFigure.style.left = "45px";
        articleEl.insertBefore(firstFigure, document.getElementById("fig2"));
   
        figureCount = 5;
        //change button to hide extra images
        var numberButton = document.querySelector("#fiveButton p");
        numberButton.innerHTML = "Show fewer images";
        if (numberButton.addEventListener) {
            numberButton.removeEventListener("click", previewFive, false);
            numberButton.addEventListener("click", previewThree, false);
        } else if (numberButton.attachEvent) {
            numberButton.detachEvent("onclick", previewFive);
            numberButton.attachEvent("onclick", previewThree);
        }
   
        // add appropriate src values to two new img elements
        document.getElementsByTagName("img")[0].src = "images/IMG_0" + photoOrder[0] + "sm.jpg";
        document.getElementsByTagName("img")[4].src = "images/IMG_0" + photoOrder[4] + "sm.jpg";
    }

    /* switch to 3-image layout */
    function previewThree() {
        var articleEl = document.getElementsByTagName("article")[0];
        var numberButton = document.querySelector("#fiveButton p");
        figureCount = 3;
        articleEl.removeChild(document.getElementById("fig1"));
        articleEl.removeChild(document.getElementById("fig5"));
        numberButton.innerHTML = "Show more images";
        if (numberButton.addEventListener) {
            numberButton.removeEventListener("click", previewThree, false);
            numberButton.addEventListener("click", previewFive, false);
        } else if (numberButton.attachEvent) {
            numberButton.detachEvent("onclick", previewThree);
            numberButton.attachEvent("onclick", previewFive);
        }
    }

    /* open center figure in separate window */
    function zoomFig() {
        var propertyWidth = 960;
        var propertyHeight  = 600;
        var winLeft = ((screen.width - propertyWidth) / 2);
        var winTop = ((screen.height - propertyHeight) / 2);
        var winOptions = "width=960,height=600";
        winOptions += ",left=" + winLeft;
        winOptions += ",top=" + winTop;
        var zoomWindow = window.open("zoom.htm", "zoomwin", winOptions);
        zoomWindow.focus();
    }


    /* create event listeners for left arrow, right arrow, and center figure element */
    function createEventListeners() {
        var leftarrow = document.getElementById("leftarrow");
        if (leftarrow.addEventListener) {
            leftarrow.addEventListener("click", leftArrow, false); 
        } else if (leftarrow.attachEvent)  {
            leftarrow.attachEvent("onclick", leftArrow);
        }

        var rightarrow = document.getElementById("rightarrow");
        if (rightarrow.addEventListener) {
            rightarrow.addEventListener("click", rightArrow, false); 
        } else if (rightarrow.attachEvent)  {
            rightarrow.attachEvent("onclick", rightArrow);
        }

        var mainFig = document.getElementsByTagName("img")[1];
        if (mainFig.addEventListener) {
            mainFig.addEventListener("click", zoomFig, false); 
        } else if (mainFig.attachEvent)  {
            mainFig.attachEvent("onclick", zoomFig);
        }
   
        var showAllButton = document.querySelector("#fiveButton p");
        if (showAllButton.addEventListener) {
            showAllButton.addEventListener("click", previewFive, false);
        } else if (showAllButton.attachEvent) {
            showAllButton.attachEvent("onclick", previewFive);
        }
    }

    /* create event listeners and populate image elements */
    function setUpPage() {
        createEventListeners();
        populateFigures();
    }

    /* run setUpPage() function when page finishes loading */
    if (window.addEventListener) {
        window.addEventListener("load", setUpPage, false); 
    } else if (window.attachEvent)  {
        window.attachEvent("onload", setUpPage);
    }
