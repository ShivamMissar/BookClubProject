// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openNavigationSide() {
    // this will extend the width of the navigation when clicked on
    document.getElementById("sideNav").style.width = "250px";
}

function closeNavigationSide() {
    //when the X button is clicked, the NAV will then be hidden
    document.getElementById("sideNav").style.width = "0";
}

function enableDarkMode() {
    // need to first retrieve the body element of the application
    var captureWholeScreen = document.body;
    // Once retrieved, need to access the class list and applies that CSS class when clicked.
    captureWholeScreen.classList.toggle("darkMode");
}