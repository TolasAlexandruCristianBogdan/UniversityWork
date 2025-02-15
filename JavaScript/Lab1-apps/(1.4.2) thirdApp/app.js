var counter = 0;

function printValue(divId, value) {
  console.log(value); // Instead of updating an HTML element, log the value to the console
}

printValue("counter", 0);

document.getElementById("inc").addEventListener("click", increment);
document.getElementById("dec").addEventListener("click", decrement);

function increment() {
  if (counter < 10) {
    counter++;
    printValue("counter", counter);
  }
}

function decrement() {
  if (counter > 0) {
    counter--;
    printValue("counter", counter);
  }
}

