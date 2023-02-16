const timer = document.getElementById('theTimer');
let interval;

//stop start buttons for the timer.
const stop = document.getElementById('stopTimerButton');
const start = document.getElementById('startTimerButton');

// these are let because their values will be changed.


function startTimer() {

    let userHour = document.getElementById('hour');
    let userMin = document.getElementById('minute');
    let userSeconds = document.getElementById('seconds');

    // if all the values are 0 then set the values to be 0.
    if (userHour == 0 && userMin == 0) {
        userHour.value = 0;
        userMin.value = 0;
        userSeconds.value = 0;
    }
    // if the seconds is not 0 then decrement the value by 1
    else if (userSeconds.value != 0) {
        userSeconds.value--;
    }
    /*if the minute is not 0 and the seconds is then set the value of seconds equal to 59 
     * as there is a total of 60 seconds and then decrement the value of min by 1
    */
    else if (userMin.value != 0 && userSeconds.value == 0) {
        userSeconds.value = 59;
        userMin.value--;
    }
    // this is the same case as above.
    else if (userHour.value != 0 && userMin.value == 0) {
        userMin.value = 59;
        userMin.value--;
    }

    return timer.innerHTML = `${userHour.value}:${userMin.value}:${userSeconds.value}`;

}


start.addEventListener('click', function () {
    interval = setInterval(function () {
        startTimer();
    }, 1000);
});

// this will pause the timer.
stop.addEventListener('click', function () {
    clearInterval(interval);
});

function hideFunction() {
    document.getElementById('hour').classList.toggle('hideInputs');
    document.getElementById('minute').classList.toggle('hideInputs');
    document.getElementById('seconds').classList.toggle('hideInputs');
}
