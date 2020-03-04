var gemiddeldeA = ["3","5","2","3","2","0"]
var gemiddeldeCijfer = new Array(5);
var puntenbehaald = new Array(5);

let studiepuntenBehaaldCluster1 = document.getElementById("studiepuntenBehaaldCluster1");
let studiepuntenBehaaldCluster2 = document.getElementById("studiepuntenBehaaldCluster2");
let studiepuntenBehaaldCluster3 = document.getElementById("studiepuntenBehaaldCluster3");
let studiepuntenBehaaldCluster4 = document.getElementById("studiepuntenBehaaldCluster4");
let studiepuntenBehaaldCluster5 = document.getElementById("studiepuntenBehaaldCluster5");

let PROJ = document.getElementById("PROJ");
let TPR = document.getElementById("TPR");
let PRO1 = document.getElementById("PRO1");
let PRO2= document.getElementById("PRO2");
let SLB = document.getElementById("SLB");
let WVO= document.getElementById("WVO");
let ENG = document.getElementById("ENG");
let NED = document.getElementById("NED");
let REK = document.getElementById("REK")
let DIFF = document.getElementById("DIFF");


let gemiddeldeCluster1 = document.getElementById("gemiddeldeCluster1");
let gemiddeldeCluster2 = document.getElementById("gemiddeldeCluster2");
let gemiddeldeCluster3 = document.getElementById("gemiddeldeCluster3");
let gemiddeldeCluster4 = document.getElementById("gemiddeldeCluster4");
let gemiddeldeCluster5 = document.getElementById("gemiddeldeCluster5");

PROJ.addEventListener("input", berekenGemiddeldeCluster1);
TPR.addEventListener("input", berekenGemiddeldeCluster1);
PRO1.addEventListener("input", berekenGemiddeldeCluster2);
PRO2.addEventListener("input", berekenGemiddeldeCluster2);
SLB.addEventListener("input", berekenGemiddeldeCluster3);
WVO.addEventListener("input", berekenGemiddeldeCluster3);
ENG.addEventListener("input", berekenGemiddeldeCluster4);
NED.addEventListener("input", berekenGemiddeldeCluster4);
REK.addEventListener("input", berekenGemiddeldeCluster4);
DIFF.addEventListener("input", berekenGemiddeldeCluster5);


// cluster 1
function berekenGemiddeldeCluster1()
    {
        gemiddeldeCijfer[0] = (parseFloat(PROJ.value) + parseFloat(TPR.value))/2;
        gemiddeldeCluster1.innerHTML = gemiddeldeCijfer[0].toFixed(1);

        if(isNaN(gemiddeldeCijfer[0])){
          gemiddeldeCluster1.bgColor = "";
          gemiddeldeCluster1.innerHTML = "Gemiddelde";
          studiepuntenBehaaldCluster1.bgColor ="";
          studiepuntenBehaaldCluster1.innerHTML = "studiepunten";
          berekenTotaalSP();
        }
        else{

                if(gemiddeldeCijfer[0] >= 5.5){
                  studiepuntenBehaaldCluster1.bgColor ="green";
                    studiepuntenBehaaldCluster1.innerHTML = gemiddeldeA[0];
                    puntenbehaald[0]=gemiddeldeA[0];
                    gemiddeldeCluster1.bgColor = "green";
                }
                else {studiepuntenBehaaldCluster1.innerHTML = gemiddeldeA[5];
                  puntenbehaald[0]=0;
                studiepuntenBehaaldCluster1.bgColor ="red";
                gemiddeldeCluster1.bgColor = "red";}

                berekenTotaalSP();
            }
        }
// Cluster2
function berekenGemiddeldeCluster2()
    {
        gemiddeldeCijfer[1] = (parseFloat(PRO1.value) + parseFloat(PRO2.value))/2;
        gemiddeldeCluster2.innerHTML = gemiddeldeCijfer[1].toFixed(1);

        if(isNaN(gemiddeldeCijfer[1])){
          gemiddeldeCluster2.bgColor = "";
          gemiddeldeCluster2.innerHTML = "Gemiddelde";
          studiepuntenBehaaldCluster2.bgColor ="";
          studiepuntenBehaaldCluster2.innerHTML = "studiepunten";
          berekenTotaalSP();
        }
        else{

                if(gemiddeldeCijfer[1] >= 5.5){
                  studiepuntenBehaaldCluster2.bgColor ="green";
                    studiepuntenBehaaldCluster2.innerHTML = gemiddeldeA[1];
                    puntenbehaald[1]=gemiddeldeA[1];
                    gemiddeldeCluster2.bgColor = "green";
                }
                else {studiepuntenBehaaldCluster2.innerHTML = gemiddeldeA[5];
                  puntenbehaald[0]=0;
                studiepuntenBehaaldCluster2.bgColor ="red";
                gemiddeldeCluster2.bgColor = "red";}

                berekenTotaalSP();
            }
        }

// Cluster3

function berekenGemiddeldeCluster3()
    {
        gemiddeldeCijfer[2] = (parseFloat(SLB.value) + parseFloat(WVO.value))/2;
        gemiddeldeCluster3.innerHTML = gemiddeldeCijfer[2].toFixed(1);

        if(isNaN(gemiddeldeCijfer[2])){
          gemiddeldeCluster3.bgColor = "";
          gemiddeldeCluster3.innerHTML = "Gemiddelde";
          studiepuntenBehaaldCluster3.bgColor ="";
          studiepuntenBehaaldCluster3.innerHTML = "studiepunten";
          berekenTotaalSP();
        }
        else{

                if(gemiddeldeCijfer[2] >= 5.5){
                  studiepuntenBehaaldCluster3.bgColor ="green";
                    studiepuntenBehaaldCluster3.innerHTML = gemiddeldeA[2];
                    puntenbehaald[2]=gemiddeldeA[2];
                    gemiddeldeCluster3.bgColor = "green";
                }
                else {studiepuntenBehaaldCluster3.innerHTML = gemiddeldeA[5];
                  puntenbehaald[2]=0;
                studiepuntenBehaaldCluster3.bgColor ="red";
                gemiddeldeCluster3.bgColor = "red";}

                berekenTotaalSP();
            }
        }


// Cluster 4
function berekenGemiddeldeCluster4()
    {
        gemiddeldeCijfer[3] = (parseFloat(ENG.value) + parseFloat(NED.value) + parseFloat(REK.value))/3;
        gemiddeldeCluster4.innerHTML = gemiddeldeCijfer[3].toFixed(1);

        if(isNaN(gemiddeldeCijfer[3])){
          gemiddeldeCluster4.bgColor = "";
          gemiddeldeCluster4.innerHTML = "Gemiddelde";
          studiepuntenBehaaldCluster4.bgColor ="";
          studiepuntenBehaaldCluster4.innerHTML = "studiepunten";
          berekenTotaalSP();
        }
        else{

                if(gemiddeldeCijfer[3] >= 5.5){
                  studiepuntenBehaaldCluster4.bgColor ="green";
                    studiepuntenBehaaldCluster4.innerHTML = gemiddeldeA[3];
                    puntenbehaald[3]=gemiddeldeA[3];
                    gemiddeldeCluster4.bgColor = "green";
                }
                else {studiepuntenBehaaldCluster4.innerHTML = gemiddeldeA[5];
                  puntenbehaald[4]=0;
                studiepuntenBehaaldCluster4.bgColor ="red";
                gemiddeldeCluster4.bgColor = "red";}

                berekenTotaalSP();
            }
        }


// Cluster 5
function berekenGemiddeldeCluster5()
    {
        gemiddeldeCijfer[4] = parseFloat(DIFF.value);
        gemiddeldeCluster5.innerHTML = gemiddeldeCijfer[4].toFixed(1);

        if(isNaN(gemiddeldeCijfer[4])){
          gemiddeldeCluster5.bgColor = "";
          gemiddeldeCluster5.innerHTML = "Gemiddelde";
          studiepuntenBehaaldCluster5.bgColor ="";
          studiepuntenBehaaldCluster5.innerHTML = "studiepunten";
          berekenTotaalSP();
        }
        else{

                if(gemiddeldeCijfer[4] >= 5.5){
                  studiepuntenBehaaldCluster5.bgColor ="green";
                    studiepuntenBehaaldCluster5.innerHTML = gemiddeldeA[4];
                    puntenbehaald[4]=gemiddeldeA[4];
                    gemiddeldeCluster5.bgColor = "green";
                }
                else {studiepuntenBehaaldCluster5.innerHTML = gemiddeldeA[5];
                  puntenbehaald[4]=0;
                studiepuntenBehaaldCluster5.bgColor ="red";
                gemiddeldeCluster5.bgColor = "red";}

                berekenTotaalSP();
            }
        }


// Totaal aantal Studiepunten

let totaalSP = document.getElementById("totaalSP");
function berekenTotaalSP()
    {

        let studiepuntenTotaal = parseFloat(puntenbehaald[0]) +
        parseFloat(puntenbehaald[1]) +
        parseFloat(puntenbehaald[2]) +
        parseFloat(puntenbehaald[3]) +
        parseFloat(puntenbehaald[4]);
        totaalSP.innerHTML = studiepuntenTotaal;

        if(isNaN(studiepuntenTotaal)){
          totaalSP.bgColor = "orange";
          totaalSP.innerHTML ="I cant work with this<br>did you fill everything in?"
        }
        else{

                if(studiepuntenTotaal >= 12){
                  totaalSP.bgColor ="green";
                    totaalSP.innerHTML = studiepuntenTotaal;
                }
                else {
                totaalSP.bgColor ="red";
                totaalSP.innerHTML = studiepuntenTotaal;
            }
          }
    }
