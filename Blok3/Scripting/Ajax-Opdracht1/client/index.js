console.log("UP AND RUNNING!");
let FirstName = document.getElementById("firstname");
let LastName = document.getElementById("lastname");
let AGE = document.getElementById("age");
let RESPONSE = document.getElementById("SUBMIT");

function Ajax2() {
    xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            console.log(this.responseText);
            document.getElementById("RESPONSE").innerHTML = this.responseText;
        }
    }

    let httplink = "../server/InputCompleter.php?firstname=" + FirstName.value + "&lastname=" + LastName.value + "&age=" + AGE.value;

    xmlhttp.open("GET", httplink, true)
    xmlhttp.send()
}
RESPONSE.addEventListener("click", function () {
    Ajax2();
});
