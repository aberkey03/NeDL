function validateAndAdd(){
    
    //get initial values from list
    let newMin = parseInt(document.getElementById("newMinValue").value); //parseInt takes the text entry string and converts to int
    let newMax = parseInt(document.getElementById("newMaxValue").value);
    let newValue = parseInt(document.getElementById("newValue").value);
    

    //validate min value is entered
    if(newMin == ""){
        alert("Enter a minimum value.")
    }
    //validate max value is entered
    if(newMax == ""){
        alert("Enter a maximum value.")
    }
    //validate max value is > min value
    else if (newMax <= newMin){
        alert("The maximum must be greater than the minimum.")
    }
    //validate the new value is entered
    else if(newValue==""){
        alert("Enter a new value to add.")
    }
    //validate new value is >min and <max
    else if (newValue > newMax || newValue < newMin){
        alert("The new value must be more than the minimum, and less than the maximum.")
    }
    
    
    else{
        //alert("Add the new value to the list!")
        //add new value to the list
        let tableRef = document.getElementById("userEntriesList");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = newValue;

        //calulate mean and add to mean lable
        let sum = 0; //initial value set to 0
        let numRows = tableRef.rows.length; //set numRows =  length of the table 
        for(let i=0;i<numRows;i++){
            sum = sum + parseInt(tableRef.rows[i].innerHTML); // arseInt takes the string value from the table, and converts to int
        };
        let newMean = sum/numRows; //calc mean
        document.getElementById("theMean").innerHTML = newMean; //set theMean lable = newMean

        //calculate median and add to median lable
        //create an array
        const numArray = [];
        //add each rows value to the array
        for(let i=0;i<numRows;i++){
            numArray.push(parseInt(tableRef.rows[i].innerHTML));
        }
        //sort the array
        numArray.sort();
        //find the middle
        let theMiddle = Math.trunc(numRows/2);
        //determine if the number of numbers is odd or even
        let remainder = numRows%2;
            //find the median (even)
            if(remainder == 0){
                console.log("array is even")
                let newMedian = (numArray[theMiddle] + numArray[theMiddle-1])/2;
                document.getElementById("theMedian").innerHTML = newMedian; //set theMedian lable = newMedian
            }
            //find the median (odd)
            else{
                console.log("array is odd")
                let newMedian = numArray[theMiddle];
                document.getElementById("theMedian").innerHTML = newMedian; //set theMedian lable = newMedian
            }

        //calculate mode and add to the mode lable

        // erase the number in the form
        document.forms["numberForm"]["newValue"].value = "";

        // disable the min and max range so the range can't change
        document.forms["numberForm"]["newMinValue"].disabled = true;
        document.forms["numberForm"]["newMaxValue"].disabled = true;
    };
}

function clearList(){
    alert("Clear list!")
    //set list contens to ""
    let tableRef = document.getElementById("userEntriesList");
    tableRef.innerHTML = "";
    //set mean, median, and mode lables to ""
    document.getElementById("theMean")  .innerHTML = "";
    document.getElementById("theMedian")  .innerHTML = "";
    //re-enable form
    document.forms["numberForm"]["newMinValue"].disabled = false;
    document.forms["numberForm"]["newMaxValue"].disabled = false;
    //clear form values
    document.getElementById("newMinValue").value =""; 
    document.getElementById("newMaxValue").value ="";
    document.getElementById("newValue").value = "";
    
}