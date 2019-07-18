document.getElementById("province").selectedIndex = -1;
var bool = true;
function checkPostCodeFormat() {
    var postCodeValue = document.getElementById("postCode").value;
    var canadaPostCodeFormat = /[A-Za-z][0-9][A-Za-z] [0-9][A-Za-z][0-9]/;
    if (!canadaPostCodeFormat.test(postCodeValue)){
        window.alert("The post code format is wrong.");
        return false;

    }


}
function checkAge() {
    var ageValue = document.getElementById("age").value;
    if (ageValue < 18){
        window.alert("Age has to be at least 18 yrs. old.");
        return false;
    }

}
function checkPasswordCharacters () {
    var passwordLength = document.getElementById("password").value.length;
    if (passwordLength < 6){
        window.alert("Passwords must have at least 6 characters.");
        return false;
    }

}
function confirmPassword () {
    var password = document.getElementById("password").value;
    var confirmPassword = document.getElementById("confirm").value;
    if (confirmPassword !== password){
        window.alert("Password and Confirm must be same.");
        return false;
    }

}
function checkEmail() {
    var email = document.getElementById("email").value;
    var emailFormat = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if (!emailFormat.test(email)) {
        window.alert("The Email field must contain the @ and . characters");
        return false;
    }


}

function checkFirstName(){
    var first = document.getElementById("firstName").value;
        if (first.length == 0) {
        window.alert("Please enter your first name!")
        return false;
    }
}
function checkLastName(){
    var last = document.getElementById("lastName").value;
        if (last.length == 0) {
        window.alert("Please enter your last name")
        return false;
    }
}

function checkAddress(){
    var address = document.getElementById("adress").value;
        if (address.length == 0) {
        window.alert("Please provide your address")
        return false;
    }
}
function checkCity(){
    var city = document.getElementById("city").value;
        if (city.length == 0) {
        window.alert("Please provide the city you are living")
        return false;
    }
}


function finalCheck() {
    if (checkPostCodeFormat()===false || checkAge()===false ||
        checkPasswordCharacters()=== false || confirmPassword()=== false || checkEmail()=== false || 
        checkFirstName()===false||checkLastName()===false||checkAddress()===false||checkCity()===false){
        return false;
    }
    else {
        window.alert("Thanks for registering with our website," +
            " your customer record was created successfully.");
        return true;
    }
}

function createEventListener() {
    var postCodeChecker = document.getElementById("postCode");
    if (postCodeChecker.addEventListener){
        postCodeChecker.addEventListener("change",checkPostCodeFormat,false);
    }
    else if (postCodeChecker.attachEvent){
        postCodeChecker.attachEvent("onchange",checkPostCodeFormat());
    }
    var ageChecker = document.getElementById("age");
    if (ageChecker.addEventListener){
        ageChecker.addEventListener("change",checkAge,false);
    }
    else if (ageChecker.attachEvent){
        ageChecker.attachEvent("onchange",checkAge());
    }
    var passwordsCharactersChecker = document.getElementById("password");
    if (passwordsCharactersChecker.addEventListener){
        passwordsCharactersChecker.addEventListener("change",checkPasswordCharacters,false);
    }
    else if (passwordsCharactersChecker.attachEvent){
        passwordsCharactersChecker.attachEvent("onchange",checkPasswordCharacters());
    }
    var confirmPasswordChecker = document.getElementById("confirm");
    if (confirmPasswordChecker.addEventListener){
        confirmPasswordChecker.addEventListener("change",confirmPassword,false);
    }
    else if (confirmPasswordChecker.attachEvent){
        confirmPasswordChecker.attachEvent("onchange",confirmPassword());
    }
}
if (window.addEventListener) {
    window.addEventListener("load", createEventListener,
        false);
} else if (window.attachEvent) {
    window.attachEvent("onload", createEventListener);
}