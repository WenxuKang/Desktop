/*

 *  Name:        Gaofeng Pan

 *  Student No.: 300973143

 *  Course:      COMP125

 *  Professor:   Viktor Valeriyovych Zaytsev

 *  Semester:    Summer 2018

 *  File Name:   assignment1.js

 */

 

var male = document.getElementById("male");

var female = document.getElementById("female");

var age = document.getElementById("age");

 

var feet = document.getElementById("feet");

var inches = document.getElementById("inches");

var pounds = document.getElementById("pounds");

 

var actLevel = 0;

var bmrImperial = 0;

 

function calcImperialBMR() {

          

           if (sedentary.checked) {

        actLevel = 1.53;

    }

    else if (moderate.checked) {

        actLevel = 1.76;       

    }

    else if (vigorously.checked) {

        actLevel =  2.25;

    }

 

           var totalINCHES = (parseFloat(feet.value) * 12) + parseFloat(inches.value);

           console.log("inches " +totalINCHES);

 

          

           if (male.checked) {

        bmrImperial = (66 + (6.2 * pounds.value) + (12.7 * totalINCHES) - (6.76 * age.value));

    console.log("maleBMRimperial" +bmrImperial);

    }

    else if (female.checked) {

        bmrImperial = (655.1 + (4.35 * pounds.value) + (4.7 * totalINCHES) - (4.7 * age.value));

    console.log("femaleBMRimperial" +bmrImperial);

    }

 

    var calIntake = bmrImperial * actLevel;

 

    document.getElementById("resultBMR").textContent = bmrImperial.toFixed(2);

    document.getElementById("resultCal").textContent = calIntake.toFixed(2);

}

document.getElementById("submitImperic").addEventListener("click", calcImperialBMR, false);
