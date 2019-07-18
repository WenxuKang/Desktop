
/* create event listeners  */
function createEventListeners() {
    var calculateBtn = document.getElementById("calculateBtn");    

    // add buttons listeners here

}

/* run setup functions when page finishes loading */
if (window.addEventListener) {
   window.addEventListener("load", createEventListeners, false);
} else if (window.attachEvent) {
   window.attachEvent("onload", createEventListeners);
}