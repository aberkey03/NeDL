function checkPalendrome() {
    let userEntryWord = document.getElementById("word").value;
    let userEntryAlorithim = document.getElementById("algorithim").value;
    if(userEntryWord == ""){
        alert ("Enter a word to check if it is a checkPalendrome.");
        return false;
    }
    else if (userEntryAlorithim !=1 && userEntryAlorithim !=2){
        alert ("Only 1 or 2 is accepted. Try again.")
        return false;
    }
    else
    {
        if (userEntryAlorithim == 1){
            let algortithimTable = document.getElementById("list1");
            let onlyLetters = userEntryWord.toLowerCase().replace(/[\W_]/g, '');
            //split the string into individual characters, stored in an array called split
            let split = onlyLetters.split("");
            /* for (let i = 0; i < split.length; i++){
                (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = split[i];
            } */
            let reverse = split.reverse();
            /* for (let i = 0; i < reverse.length; i++){
                (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = reverse[i];
            } */
            let join = reverse.join("");
            /* (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = join; */
            if (join == onlyCharacters){
                (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = userEntryWord + " true";
            }
            else{
                (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = userEntryWord + " false";
            }
        }
        else if (userEntryAlorithim ==2){
            let algortithimTable = document.getElementById("list2");
            let reverse = "";
            /* (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = userEntryWord;
            (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = reverse; */
            //length = maxIndex +1, so length - 1 = maxIndex
            //loop through the string as an array from the end to the begining (ie reverse order)
            for (let i = userEntryWord.length -1; i>=0; i--){
                //add each leter from end to begining to form a new string
                reverse = reverse + userEntryWord[i];
                /* (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = reverse; */
            }
            if (reverse == userEntryWord){
                (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = userEntryWord + " true";
            }
            else {
                (algortithimTable.insertRow(algortithimTable.rows.length)).innerHTML = userEntryWord + " false";
            }
        }
    }
    alert(userEntryWord + " " + userEntryAlorithim);
}

function clearList1(){
    let algortithimTable = document.getElementById("list1");
    algortithimTable.innerHTML="";
}

function clearList2(){
    let algortithimTable = document.getElementById("list2");
    algortithimTable.innerHTML="";
}
