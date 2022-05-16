async function getBacon(){
    console.log("Button is connected!");

    //declare initial api string
    let apiString = "https://baconipsum.com/api/";
    console.log(apiString);
    //apend user variables
    let numParagraphs = document.getElementById("numParagraphs").value;
    let meatOrFiller = document.getElementById("meat or filler").value;

    apiString = apiString + "?" + meatOrFiller + "&paras=" + numParagraphs;
    console.log(apiString);

    //declare variable to hold the API response
    let response = await fetch(apiString); //use await with async function

    //clear old text
    document.getElementById("jsonText").innerHTML = "";
    document.getElementById("formatedText").innerHTML = "";
    console.log("Columns are clear");

    //create JSON object from response
    let jsonText = await response.json();

    //print JSON
    document.getElementById("jsonText").innerHTML = JSON.stringify(jsonText);
    console.log("Json has been stringified and should have printed!");

    //print formated 
    for (let para in jsonText){
        document.getElementById("formatedText").innerHTML += "<p>" + jsonText[para] + "</p>";
    } 
    return true;
}