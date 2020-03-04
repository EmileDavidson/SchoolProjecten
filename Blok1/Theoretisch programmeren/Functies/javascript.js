let gerecht = document.getElementById("gerecht");
let gerecht2 = document.getElementById("gerecht2");

let stap1 = document.getElementById("stap1");
let stap2 = document.getElementById("stap2");
let stap3 = document.getElementById("stap3");
let stap4 = document.getElementById("stap4");
let stap5 = document.getElementById("stap5");
let stap6 = document.getElementById("stap6");
let stap7 = document.getElementById("stap7");
let stap8 = document.getElementById("stap8");
let stap9 = document.getElementById("stap9");
let stap10 = document.getElementById("stap10");
let stap11 = document.getElementById("stap11");
let stap12 = document.getElementById("stap12");
let stap13 = document.getElementById("stap13");


let button1 = document.getElementById('button1');
button1.addEventListener('click', ()=>{
spaghetti();
Hamkaas();
color();
document.getElementById("button1").style.color = "#ff0000";
})
let button2 = document.getElementById('button2');
button2.addEventListener('click', ()=>{
Macaroni();
Hamkaas();
color();
document.getElementById("button2").style.color = "#ff0000";
})
let button3 = document.getElementById('button3');
button3.addEventListener('click', ()=>{
Tagliatelli();
Hamkaas();
color();
document.getElementById("button3").style.color = "#ff0000";
})
let button4 = document.getElementById('button4');
button4.addEventListener('click', ()=>{
spaghetti();
spinazieroom();
color();
document.getElementById("button4").style.color = "#ff0000";
})
let button5 = document.getElementById('button5');
button5.addEventListener('click', ()=>{
Macaroni();
spinazieroom();
color();
document.getElementById("button5").style.color = "#ff0000";
})
let button6 = document.getElementById('button6');
button6.addEventListener('click', ()=>{
Tagliatelli();
spinazieroom();
color();
document.getElementById("button6").style.color = "#ff0000";
})
let button7 = document.getElementById('button7');
button7.addEventListener('click', ()=>{
spaghetti();
gehakttomatensauskaas();
color();
document.getElementById("button7").style.color = "#ff0000";
})
let button8 = document.getElementById('button8');
button8.addEventListener('click', ()=>{
Macaroni();
gehakttomatensauskaas();
color();
document.getElementById("button8").style.color = "#ff0000";
})
let button9 = document.getElementById('button9');
button9.addEventListener('click', ()=>{
Tagliatelli();
gehakttomatensauskaas();
color();
document.getElementById("button9").style.color = "#ff0000";
})
let button10 = document.getElementById('button10');
button10.addEventListener('click', ()=>{
spaghetti();
spekjesspinazieroom();
color();
document.getElementById("button10").style.color = "#ff0000";
})
let button11 = document.getElementById('button11');
button11.addEventListener('click', ()=>{
Macaroni();
spekjesspinazieroom();
color();
document.getElementById("button11").style.color = "#ff0000";
})
let button12 = document.getElementById('button12');
button12.addEventListener('click', ()=>{
Tagliatelli();
spekjesspinazieroom();
color();
document.getElementById("button12").style.color = "#ff0000";
})
let button13 = document.getElementById('button13');
button13.addEventListener('click', ()=>{
spaghetti();
courgettetomatensaus();
color();
document.getElementById("button13").style.color = "#ff0000";
})
let button14 = document.getElementById('button14');
button14.addEventListener('click', ()=>{
Macaroni();
courgettetomatensaus();
color();
document.getElementById("button14").style.color = "#ff0000";
})
let button15 = document.getElementById('button15');
button15.addEventListener('click', ()=>{
Tagliatelli();
courgettetomatensaus();
color();
document.getElementById("button15").style.color = "#ff0000";
})

function spaghetti() {
gerecht.innerHTML = "Spaghetti";
stap1.innerHTML = "Dit is de eerste stap voor het maken van spaghetti";
stap2.innerHTML = "Dit is de tweede stap voor het maken van spaghetti";
stap3.innerHTML = "Dit is de derde stap voor het maken van spaghetti";
stap4.innerHTML = "Dit is de vierde stap voor het maken van spaghetti";
stap5.innerHTML = "Dit is de vijfde stap voor het maken van spaghetti";
stap6.innerHTML = "Dit is de zesde stap voor het maken van spaghetti";
stap7.innerHTML = "Dit is de sevende stap voor het maken van spaghetti";

}
function Macaroni() {
gerecht.innerHTML = "Macaroni";
stap1.innerHTML = "Dit is de eerste stap voor het maken van Macaroni";
stap2.innerHTML = "Dit is de tweede stap voor het maken van Macaroni";
stap3.innerHTML = "Dit is de derde stap voor het maken van Macaroni";
stap4.innerHTML = "Dit is de vierde stap voor het maken van Macaroni";
stap5.innerHTML = "Dit is de vijfde stap voor het maken van Macaroni";
stap6.innerHTML = "Dit is de zesde stap voor het maken van Macaroni";
stap7.innerHTML = "Dit is de sevende stap voor het maken van Macaroni";
}
function Tagliatelli() {
gerecht.innerHTML = "Tagliatelli";
stap1.innerHTML = "Dit is de eerste stap voor het maken van Tagliatelli";
stap2.innerHTML = "Dit is de tweede stap voor het maken van Tagliatelli";
stap3.innerHTML = "Dit is de derde stap voor het maken van Tagliatelli";
stap4.innerHTML = "Dit is de vierde stap voor het maken van Tagliatelli";
stap5.innerHTML = "Dit is de vijfde stap voor het maken van Tagliatelli";
stap6.innerHTML = "Dit is de zesde stap voor het maken van Tagliatelli";
stap7.innerHTML = "Dit is de sevende stap voor het maken van Tagliatelli";
}

function Hamkaas() {
gerecht2.innerHTML = "ham en kaas";
stap8.innerHTML = "dit is de eerste(8) stap voor het maken van ham en kaas";
stap9.innerHTML = "dit is de tweede(9) stap voor het maken van ham en kaas";
stap10.innerHTML = "dit is de derde(10) stap voor het maken van ham en kaas";
stap11.innerHTML = "dit is de vierde(11) stap voor het maken van ham en kaas";
stap12.innerHTML = "dit is de vijfde(12) stap voor het maken van ham en kaas";
stap13.innerHTML = "dit is de zesde(13) stap voor het maken van ham en kaas";
}
function spinazieroom() {
gerecht2.innerHTML = "spinazie en room";
stap8.innerHTML = "dit is de eerste(8) stap voor het maken van spinazie en room";
stap9.innerHTML = "dit is de tweede(9) stap voor het maken van spinazie en room";
stap10.innerHTML = "dit is de derde(10) stap voor het maken van spinazie en room";
stap11.innerHTML = "dit is de vierde(11) stap voor het maken van spinazie en room";
stap12.innerHTML = "dit is de vijfde(12) stap voor het maken van spinazie en room";
stap13.innerHTML = "dit is de zesde(13) stap voor het maken van spinazie en room";
}
function gehakttomatensauskaas() {
gerecht2.innerHTML = "gehakt-tomatensaus en kaas";
stap8.innerHTML = "dit is de eerste(8) stap voor het maken van gehakt-tomatensaus en kaas";
stap9.innerHTML = "dit is de tweede(9) stap voor het maken van gehakt-tomatensaus en kaas";
stap10.innerHTML = "dit is de derde(10) stap voor het maken van gehakt-tomatensaus en kaas";
stap11.innerHTML = "dit is de vierde(11) stap voor het maken van gehakt-tomatensaus en kaas";
stap12.innerHTML = "dit is de vijfde(12) stap voor het maken van gehakt-tomatensaus en kaas";
stap13.innerHTML = "dit is de zesde(13) stap voor het maken van gehakt-tomatensaus en kaas";
}
function spekjesspinazieroom() {
gerecht2.innerHTML = "spekjes, spinazie en room";
stap8.innerHTML = "dit is de eerste(8) stap voor het maken van spakjes, spinazie en room";
stap9.innerHTML = "dit is de tweede(9) stap voor het maken van spakjes, spinazie en room";
stap10.innerHTML = "dit is de derde(10) stap voor het maken van spakjes, spinazie en room";
stap11.innerHTML = "dit is de vierde(11) stap voor het maken van spakjes, spinazie en room";
stap12.innerHTML = "dit is de vijfde(12) stap voor het maken van spakjes, spinazie en room";
stap13.innerHTML = "dit is de zesde(13) stap voor het maken van spakjes, spinazie en room";

}
function courgettetomatensaus() {
gerecht2.innerHTML = "courgette en tomatensaus";
stap8.innerHTML = "dit is de eerste(8) stap voor het maken van courgette en tomatensaus";
stap9.innerHTML = "dit is de tweede(9) stap voor het maken van courgette en tomatensaus";
stap10.innerHTML = "dit is de derde(10) stap voor het maken van courgette en tomatensaus";
stap11.innerHTML = "dit is de vierde(11) stap voor het maken van courgette en tomatensaus";
stap12.innerHTML = "dit is de vijfde(12) stap voor het maken van courgette en tomatensaus";
stap13.innerHTML = "dit is de zesde(13) stap voor het maken van courgette en tomatensaus";

}

function color() {
document.getElementById("button1").style.color = "#ffffff";
document.getElementById("button2").style.color = "#ffffff";
document.getElementById("button3").style.color = "#ffffff";
document.getElementById("button4").style.color = "#ffffff";
document.getElementById("button5").style.color = "#ffffff";
document.getElementById("button6").style.color = "#ffffff";
document.getElementById("button7").style.color = "#ffffff";
document.getElementById("button8").style.color = "#ffffff";
document.getElementById("button9").style.color = "#ffffff";
document.getElementById("button10").style.color = "#ffffff";
document.getElementById("button11").style.color = "#ffffff";
document.getElementById("button12").style.color = "#ffffff";
document.getElementById("button13").style.color = "#ffffff";
document.getElementById("button14").style.color = "#ffffff";
document.getElementById("button15").style.color = "#ffffff";
}
