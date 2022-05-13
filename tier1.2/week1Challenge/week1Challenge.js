function valdidateAndAdd(){
    //get new to do from form
    let newToDo = document.getElementById("toDoEntry").value;
    //validate newToDo is not blank
    if(newToDo == ""){
        //if blank, alert user, and return false
        alert("You can not add a blank to do. Try again."); //can also use the required properity in the HTML
        console.log("blank entry");
        return false;
    }
    else{
        //if not blank, add new to do to the list
        let tableRef = document.getElementById("incompleteToDos");
        //tableRef is id of the incomplete table
        //.insertRow is the method to add to the new row
        //(tableRef.rows.length) gets the lenght of the table to determine where to add the row
        //.innerHTML is the 'value'/innards of the row
        let newRowIndex = tableRef.rows.length;
        /* const newRowBody =(tableRef.insertRow(newRowIndex));
        console.log("body: " + newRowBody + " index: " + newRowIndex); */
        (tableRef.insertRow(newRowIndex)).innerHTML = newToDo; //try adding 1 cell instead of an entire row 
        console.log(newToDo + "has been added");
        /* let button = document.createElement("button");
        button.innerHTML = "Mark Complete";
        let buttonCell = newRowBody.insertCell(0);
        buttonCell.innerHTML = button;
        button.addEventListener("click", function() {markComplete()}); */
        //clear the form value
        document.getElementById("toDoEntry").value = "";
        console.log("the form is clear");
        return true;
    };
}

function validateAndDelete(){
    //get the to do to delete from form
    let deleteToDo = document.getElementById("toDoEntry").value;
    //validate deleteToDo is not blank
    if(deleteToDo == ""){
        //if blank, alert user, and return false
        alert("Enter an existing To Do to delete."); //can also use the required properity in the HTML
        console.log("blank entry");
        return false;
    }
    //validate toDo exists 
    else if (deleteToDo != ""){
        //tableRef is id of the incomplete table
        let tableRef = document.getElementById("incompleteToDos");
        //get number of rows (ie total index of the array to create)
        let numToDos = tableRef.rows.length;
        console.log("total todos:" + numToDos);
        //declare incompleteToDo array
        const incompleteToDo = [];
        //loop through the list and add the value to an array
        for(i=0;i<numToDos;i++){
            incompleteToDo.push(tableRef.rows[i].innerHTML);
            console.log("todo array position " + i + ": " + tableRef.rows[i].innerHTML);
        }
        console.log("full array " + incompleteToDo);
        //check the array to check if entered todo exists
        //.includes returns true or false 
        if(incompleteToDo.includes(deleteToDo)){
            //if the deleteToDo exists, delete it and return true
            console.log(deleteToDo + " exists!");
            //find the postion of deleteToDo
            let deleteLocation = -1;
            deleteLocation = incompleteToDo.indexOf(deleteToDo);
            console.log(deleteToDo + " will be removed from" + deleteLocation);
            //slice the deleteLocation out of the array
            incompleteToDo.splice(deleteLocation, 1);
            console.log(incompleteToDo);
            //clear the list element 
            tableRef.innerHTML = "";
            console.log("toDo list has been cleared");
            //reprint the array to the list
            incompleteToDo.forEach(toDo => {
                (tableRef.insertRow(tableRef.rows.length)).innerHTML = toDo;
            });
            console.log("toDo list has been reprinted");
            return true;
        }
        else{
            //if the deleteToDo exists, alert the user
            alert(deleteToDo + " does not exist. Try again.");
            return false;
        };
    };
}

function clearList(){ //how can i reuse this same function for both lists? 
    //tableRef is id of the incomplete table
    let tableRef = document.getElementById("incompleteToDos");
    //set the contents of the table to blank
    tableRef.innerHTML = "";
    console.log(tableRef.id + "has been cleared")
}

function markComplete(){
    alert("TO do has been marked complete!");
}