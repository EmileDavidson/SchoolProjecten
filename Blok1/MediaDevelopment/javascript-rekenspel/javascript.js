ag = 0;
af = 0;
let som = document.getElementById("som");
let antwoord = document.getElementById("antwoord");

let image = document.getElementById("image");
let image1 = document.getElementById("image1");

let aantalgoed = document.getElementById("aantalgoed");
let aantalfout = document.getElementById("aantalfout");

let gf = document.getElementById("gf");
let aantalgespeeld = document.getElementById("aantalgespeeld");
aantalplayed = 0;
let myOpacity = 0;  //infaden van feedbaclplaatje

let input = document.getElementById("antwoord");
makeSum();
antwoord.addEventListener("keyup", keyPressed);

function makeSum() {
  var a = Math.floor(Math.random() * 9 + 1);
  var b = Math.floor(Math.random() * 9 + 1);
  mySum = a + "x" + b;
  answer = a*b;
  som.innerHTML = mySum;
  antwoord.focus();
  aantalgoed.innerHTML = "aantal keer goed: " + ag;
  aantalfout.innerHTML = "aantal keer fout: " + af;
  aantalgespeeld.innerHTML = aantalplayed
}

function keyPressed() {

  if (event.keyCode === 13) {
    //console.log(antwoord.value);// debug
    //console.log(answer);// debug
    aantalplayed++
    event.preventDefault();
    console.log("Enter key pressed");
    if (antwoord.value == answer) {
      console.log("het gegeven antwoord is goed");
      image.classList.add("faidinAnimation");
      ag++
      input.value = "";
      waiting();
    } else if(antwoord != answer){
      console.log("Het gegeven antwoord is FOUT");
      image1.classList.add("faidinAnimation");
      af++
      input.value = "";
      waiting();
    }
  }
}
function waiting() {
  setTimeout(function () {
    image.classList.remove("faidinAnimation");
    image1.classList.remove("faidinAnimation");
    makeSum();
}, 4000);
}
