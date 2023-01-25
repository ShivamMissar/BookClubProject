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



var accordian = document.getElementsByClassName("questionToBeAnswered"); // this is  an array and therefore, the contents of the array need to be traversed.
for (i = 0; i < accordian.length; i++)
{
    accordian[i].addEventListener("click", function ()
    {
        var contentBox = this.nextElementSibling; // this part was taken from https://www.w3schools.com/howto/howto_js_accordion.asp
        // if the content box has already been opened then if clicked again it should hide the box else display the content inside.       
        if (contentBox.style.display === "block")
        {
            contentBox.style.display = "none";
        } else {
            contentBox.style.display = "block";
        }
    });
}





document.getElementById('accordian').addEventListener("click", changeArrow);

function changeArrow() {
    var Down = document.getElementById('arrowDown');
    Down.style.display = "Block";
    var Up = document.getElementById('arrowUp');
    if (Down.style.display == "None") {
        Up.style.display = "None";
        Down.style.display = "Block";
    }
    else {
        Down.style.display = "None";
        Up.style.display = "Block";
    }
}