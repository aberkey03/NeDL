function validateAndAdd() {
  // place the values in the form into variables
  var userWord = document.forms["listForm"]["word"].value;
  var userList = document.forms["listForm"]["list"].value;
  
  // validate that something was entered as a word
  if(userWord == ""){
    // no word was entered so tell the user
    alert("No word was entered. No word will be added to the list. Try again.");
    return false;
  }

  // validate that a 1 or 2 was entered as a number
  else if(userList != 1 && userList != 2){
    alert(userList + " is not valid. Try again.");
    return false;
  }

  else {
    if(userList == 1){
      //add to table 1
      alert (userList + " " + userWord);
      var tableRef = document.getElementById("list1");
      (tableRef.insertRow(tableRef.rows.length)).innerHTML = userWord;
    }
    else if(userList == 2){
      //add to table 2
      alert (userList + " " + userWord);
      var tableRef = document.getElementById("list2");
      (tableRef.insertRow(tableRef.rows.length)).innerHTML = userWord;
    }
    document.forms["listForm"]["word"].value = "";
    document.forms["listForm"]["list"].value = "";
    return true;
  }
}
