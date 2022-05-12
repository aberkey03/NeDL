function myFunction(){
    let newName : string = "";
    newName = (<HTMLInputElement>document.getElementById("firstName")).value;
    document.getElementById("greeting").innerHTML = "Hello " + newName + "!";
}