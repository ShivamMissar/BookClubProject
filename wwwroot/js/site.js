
// Write your JavaScript code.
function openNavigationSide() {
    // this will extend the width of the navigation when clicked on
    document.getElementById("sideNav").style.width = "250px";

}

function closeNavigationSide() {
    //when the X button is clicked, the NAV will then be hidden
    document.getElementById("sideNav").style.width = "0";
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





// this is local storage api which will allow the users preference of dark mode/light to be saved so that whenever they come back onto the website it will show their saved preference.



// local storage for colors:



let moodSelect = document.getElementById('mood');


moodSelect.addEventListener('change', () => {

    if (moodSelect.value == 'White') {
        enableWhiteTheme();
        localStorage.setItem('Theme', 'White');
    }
    else if (moodSelect.value == 'Blue')
    {
        enableBlueTheme();
        localStorage.setItem('Theme', 'Blue');
    }
    else if (moodSelect.value == 'Pink') {
        enablePinkTheme();
        localStorage.setItem('Theme', 'Pink');
    }
    else {
        enableGreyTheme();
        localStorage.setItem('Theme', 'Grey');
    }
});

function enableWhiteTheme() {
    document.body.classList.toggle("Simplicity");
    
}
function enableBlueTheme() {
    document.body.classList.toggle("Relaxation");
}
function enablePinkTheme() {
    document.body.classList.toggle("Friendliness");
}
function enableGreyTheme() {
    document.body.classList.toggle("Realism");
}


if (localStorage.getItem('Theme') == 'White')
{
    enableWhiteTheme();
}
else if (localStorage.getItem('Theme') == 'Blue') {
    enableBlueTheme();
}
else if (localStorage.getItem('Theme') == 'Pink')
{
    enablePinkTheme();

}
else {
    enableGreyTheme();
}



function show()
{
    var show_input = document.getElementById('showForm');
   
   
    if (show_input.style.display === "none")
    {
        show_input.style.display = "block";
    }
    else {
        show_input.style.display = "none";
    }
}



//function will be used to display a return message if the user has clicked the button for the reporting


function buttonClicked()
{
    let button = document.getElementById("reportbutton");
    let message = document.getElementById("returnMessage");


    if (button.click) {
        button.style.display = "none";
        message.innerHTML = "Thank you for your feedback"
    }

}