let loadDocument = document.getElementById("loadDocument");


loadDocument.addEventListener('click', ajax);

function ajax() {
    let xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("demo").innerHTML = this.responseText;
        }
    };
    xmlhttp.open("GET", "text_bestand.text", true);
    xmlhttp.send();
}
