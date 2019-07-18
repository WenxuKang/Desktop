function calculateSpeed(){
    var userNameElement = document.getElementById("userNameInput");
    var distanceElement = document.getElementById("distanceInput");
    var timeElement = document.getElementById("timeInput");

    var distance = parseFloat(distanceElement.value);
    var time = parseFloat(timeElement.value);

    var speed = distance / time;
    var result = "Result: Speed of user " + userNameElement.value + " is " + speed.toFixed(2) + "km/h.";
    var resultDivElementText = document.getElementById("resultText");
    resultDivElementText.innerHTML = result;

    for (var index = 0; index <= time; index++){
        var distanceInsideForLoop = speed * index;
        var pElement = document.createElement("p");
        pElement.innerHTML = "With speed " + speed.toFixed(2) + "km/h, " + index + " hour(s) can go "+ distanceInsideForLoop.toFixed(2) + " km(s).";
        resultChart.appendChild(pElement);
    }
}

function clearResults(){
    var resultDivElementText = document.getElementById("resultText");
    var resultDivElementChart = document.getElementById("resultChart");
    resultDivElementText.innerHTML = "";
    resultDivElementChart.innerHTML = "";
}

/* create event listeners  */
function createEventListeners() {
    var calculateBtn = document.getElementById("calculateBtn");    
    var clearBtn = document.getElementById("clearBtn");

       if (calculateBtn.addEventListener) {
        calculateBtn.addEventListener("click", calculateSpeed, false); 
   } else if (calculateBtn.attachEvent)  {
    calculateBtn.attachEvent("onclick", calculateSpeed);
   }

   if (clearBtn.addEventListener) {
    clearBtn.addEventListener("click", clearResults, false); 
   } else if (clearBtn.attachEvent)  {
    clearBtn.attachEvent("onclick", clearResults);
   }   
}

/* run setup functions when page finishes loading */
if (window.addEventListener) {
   window.addEventListener("load", createEventListeners, false);
} else if (window.attachEvent) {
   window.attachEvent("onload", createEventListeners);
}