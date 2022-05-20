/* function updateLocationType(){ //triggered on change, City is default
    let newLocationTypeInput = document.getElementById("search_location_type").value;
    console.log("location value: " + newLocationTypeInput);
    let newLocationSearchTypeLable = document.getElementById(newLocationTypeInput).textContent; 
    console.log("location lable: " + newLocationSearchTypeLable);
    document.getElementById("search_location_text").innerText = newLocationSearchTypeLable;
} */

async function getBreweriesSearch(){
    //clear previous resuls
    let resultsDiv = document.getElementById("results_div").innerHTML;
    resultsDiv = '';

    //declare base api URL
    let apiString = "https://api.openbrewerydb.org/breweries"; //https://www.openbrewerydb.org/documentation
    console.log(apiString);

    //add location type
    let newLocationTypeInput = document.getElementById("search_location_type").value; //city, state, or zip
    let newLocationStringInput = document.getElementById("search_location_text").value; //the city, state, or zip to search

    //replace spaces with _
    newLocationStringInput = newLocationStringInput.replace(/\s/g, '_');
    console.log(newLocationStringInput);
    
    if (newLocationTypeInput != ''){
        apiString = apiString + "?" + newLocationTypeInput + "=" + newLocationStringInput;
    }
    else{
        apiString += "?";
    };
    console.log(apiString);

    //add brewery types
    let breweryType = document.getElementsByName("brewery_type").innerHTML;
    console.log(breweryType);

    //add sort order 
    let newSortOrder = document.getElementById("sort_order_value").innerHTML; //ascending or decending (name by default)
    if (newSortOrder == "asc"){
        apiString += "&sort=type,name:asc";
    }
    else if (newSortOrder == "desc"){
        apiString += "&sort=type,name:desc";
    }
    /* else if(newSortOrder == "by_dist"){ //may not use, need to figure out GeoTaging
        apiString += "&by_dist";
    } */
    else{
        apiString = apiString;
    };
    console.log(apiString);

    //add results per page
    let resultsPerPage = document.getElementById("number_per_page").value;
    apiString = apiString + "&per_page=" + resultsPerPage;
    console.log(apiString);

    //call API
    let response = await fetch(apiString);

    //clear old text
    let resultsBody = document.getElementById("results_anchor").innerHTML;

    //create JSON object
    const jsonText = await response.json();

    //declare variables for the brewery details
    for(let i = 0; i < jsonText.length; i++){
        //declare variables for each brewery
        let breweryName = jsonText[i].name;
        let breweryType = jsonText[i].brewery_type;
        let breweryCity = jsonText[i].city;
        let breweryState = jsonText[i].state;
        let breweryCountry = jsonText[i].country;
        let breweryWebsite = jsonText[i].website_url;
        //create new paragraph for each result and then add 
        let outputParagraph = "<p class= \" " + jsonText[i].brewery_type + "\" > Brewery Name: " + breweryName + "<br> Type: " + breweryType + "<br> City: " + breweryCity + "<br> State: " + breweryState + "<br> Country: " + breweryCountry + "<br> Website: " + "<a href=\"" + breweryWebsite + "\">"  + breweryWebsite + "</a>" + "</p>";
        document.getElementById("results_anchor").innerHTML += outputParagraph;
    };
}

async function getRandomBrewery(){
    //clear previous spotlight
    let resultsBody = document.getElementById("spotlight_anchor").innerHTML;
    resultsBody = "";
    console.log("Spotlight cleared!");
    
    //declare base api URL
    let apiString = "https://api.openbrewerydb.org/breweries/random"; //https://www.openbrewerydb.org/documentation
    console.log(apiString);

    //call API
    let response = await fetch(apiString, {cache: "no-cache"});

    //create JSON object
    const jsonText = await response.json();

    //declare variables for the brewery details
    
    let breweryName = jsonText[0].name;
    let breweryType = jsonText[0].brewery_type;
    let breweryCity = jsonText[0].city;
    let breweryState = jsonText[0].state;
    let breweryCountry = jsonText[0].country;
    let breweryWebsite = jsonText[0].website_url;
    //create new paragraph for each result and then add 
    let outputParagraph = "<p class= \" " + jsonText[0].brewery_type + "\" > Brewery Name: " + breweryName + "<br> Type: " + breweryType + "<br> City: " + breweryCity + "<br> State: " + breweryState + "<br> Country: " + breweryCountry + "<br> Website: " + "<a href=\"" + breweryWebsite + "\">"  + breweryWebsite + "</a>" + "</p>";
    document.getElementById("spotlight_anchor").innerHTML = outputParagraph;
    console.log("P: " + outputParagraph);
    console.log("APIstring: " + apiString);
}

function clear(){
    document.getElementById("'results_div'").innerHTML = "";

}

function getSortOrderValue(sort_order){
    let sortOrderValue = document.getElementById("sort_order_value").innerHTML = sort_order;
    console.log("Sort order value: " + sortOrderValue);
}