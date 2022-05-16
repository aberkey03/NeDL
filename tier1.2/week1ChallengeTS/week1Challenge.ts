function validateAndAdd(){
    //get new to do
    let newToDo = (<HTMLInputElement>document.getElementById("toDoEntry")).value;
    if(newToDo == ""){
        //if blank, alert user, and return false
        alert("You can not add a blank to do. Try again."); //can also use the required properity in the HTML
        console.log("blank entry");
        return false;
    }
    else{
        //if not blank, add new to do to the list
        let tableRef = <HTMLTableElement>document.getElementById("incompleteToDos");
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
        (<HTMLInputElement>document.getElementById("toDoEntry")).value = "";
        console.log("the form is clear");
        return true;
    };
}