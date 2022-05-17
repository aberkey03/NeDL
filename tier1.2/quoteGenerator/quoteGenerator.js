async function getQuote(){
    //declare initial api string
    let apiString = "https://api.quotable.io/random";
    
    //create user variable based off selection
    let quoteLengthChoice = document.getElementById("quote_length").value;
    console.log(quoteLengthChoice);
    let quoteLengthMin = "minLength=-1";
    let quoteLengthMax = "maxLength=-1";
    if (quoteLengthChoice == "short"){
        quoteLengthMin = "minLength=1";
        quoteLengthMax = "maxLength=25";
    }
    else if (quoteLengthChoice == "medium"){
        quoteLengthMin = "minLength=25";
        quoteLengthMax = "maxLength=75";
    }
    else if (quoteLengthChoice == "long"){
        quoteLengthMin = "minLength=75";
        quoteLengthMax = "minLength=200";
    };

    //store selected tag
    let selectedTag = "tags="+ document.getElementById("tags_input").value;
    
    //apend user variables
    apiString = apiString + "?" + quoteLengthMin + "&" + quoteLengthMax + "&" + selectedTag;
    console.log(apiString);

    //declare variable to hold the API response
    let response = await fetch(apiString);

    //clear old text
    document.getElementById("quote_body").innerHTML = "";
    document.getElementById("quote_author").innerHTML = "";
    
    //create JSON object from response and stringify
    let jsonText = await response.json();
    let quoteBodyString = JSON.stringify(jsonText.content);
    let quoteAuthorString = JSON.stringify(jsonText.author);
    let quoteTagsString = JSON.stringify(jsonText.tags);
    

    document.getElementById("quote_body").innerHTML = quoteBodyString;
    document.getElementById("quote_author").innerHTML = quoteAuthorString;
    document.getElementById("quote_tags").innerHTML = quoteTagsString;
}

async function getQuoteTags(){
    alert("the page has loaded");
    //declare api string and fetch the tags
    let apiString = "https://api.quotable.io/tags";
    let response = await fetch(apiString);


    //create JSON object from response
    const jsonArray = await response.json();
    console.log(jsonArray);

    //create new array, and copy tags into it
    const tagArray = [];
    for (let i = 0; i < jsonArray.length; i++){
        tagArray.push(JSON.stringify(jsonArray[i].name))
    };
    console.log(tagArray);

    //initalize variable for the tagSelect input element, and newOption (the tag options being added)
    let tagSelect = document.getElementById("tags_input");
    let newOption = "";

    //loop through the tag array, trim the extra characters, then add the html options to the tag select input element 
    for(let i = 0; i < tagArray.length; i++){
        tagArray[i] = tagArray[i].substring(1,tagArray[i].length-1);
        //tagArray[i] = "<option value=" + tagArray[i] + ">" + tagArray[i] + "</option>";
        newOption = document.createElement("option");
        newOption.text = newOption.value = tagArray[i];
        tagSelect.add(newOption);
    };
}