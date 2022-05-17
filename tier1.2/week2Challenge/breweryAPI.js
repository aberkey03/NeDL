/* function updateLocationType(){ //triggered on change, City is default
    let newLocationTypeInput = document.getElementById("search_location_type").value;
    console.log("location value: " + newLocationTypeInput);
    let newLocationSearchTypeLable = document.getElementById(newLocationTypeInput).textContent; 
    console.log("location lable: " + newLocationSearchTypeLable);
    document.getElementById("search_location_text").innerText = newLocationSearchTypeLable;
} */

async function getBreweriesSearch(){
    //declare base api URL
    let apiString = "https://api.openbrewerydb.org/breweries"; //https://www.openbrewerydb.org/documentation
    console.log(apiString);

    //add location type
    let newLocationTypeInput = document.getElementById("search_location_type").value; //city, state, or zip
    let newLocationStringInput = document.getElementById("search_location_text").value; //the city, state, or zip to search

    // TODO replace spaces with underscore "_"
    
    if (newLocationTypeInput != ""){
        apiString = apiString + "?" + newLocationTypeInput + "=" + newLocationStringInput;
    }
    else{
        apiString += "?";
    };
    console.log(apiString);

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
    resultsBody = "";

    //create JSON object
    const jsonText = await response.json();

    //declare variables for the brewery details
    for(let i = 0; i < jsonText.length; i++){
        //declare variables for each brewery
        let breweryName = jsonText[i].name;
        let breweryType = jsonText[i].brewery_type;
        let breweryCity = jsonText[i].city;
        let breweryState = jsonText[i].state;
        let breweryCountyProvince = jsonText[i].county_province;
        let breweryWebsite = jsonText[i].website_url;
        //create new paragraph for each result and then add 
        let outputParagraph = "<p class=\"" + jsonText[i].brewery_type + "\" > Brewery Name: " + breweryName + "<br> Type: " + breweryType + "<br> City: " + breweryCity + "<br> State: " + breweryState + "<br> County/Province: " + breweryCountyProvince + "<br> Website: " + "<a href=\"" + breweryWebsite + "\">"  + breweryWebsite + "</a>" + "</p>";
        document.getElementById("results_anchor").innerHTML += outputParagraph;
    };
}

async function getRandomBrewery(){

}

function updateNumberPerPageDisplay(){

}

function getSortOrderValue(sort_order){
    let sortOrderValue = document.getElementById("sort_order_value").innerHTML = sort_order;
    console.log("Sort order value: " + sortOrderValue);
}