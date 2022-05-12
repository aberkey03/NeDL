function myFunction() {
    var newName = "";
    newName = document.getElementById("firstName").value;
    document.getElementById("greeting").innerHTML = "Hello " + newName + "!";
}
