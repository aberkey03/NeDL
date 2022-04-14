using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class Program
  {
    static int Search(string[] arr, string x)
    {
        int n = arr.Length;
        for (int i =0; i<n; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }
    static void Main(string[] args)
    {
        // DECLARE vARRIABLES
        bool userChoice;
        string userChoiceString;
        string[] nameArray = new string[10];
        int index = 0; //this is the index for the array
        string fileName = "names.txt";
      //repeat the main loop until Q is entered 
      do
        {
            //get a valid option
            do
            {
                //display menu of options
                userChoice = false; //set to false so this will run initally 
    //enter L to load the array FIrst, if not throw error
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("L: Load the data file into the array.");
                Console.WriteLine("S: Store the array into the file.");
                Console.WriteLine("C: Add a name into the array.");
                Console.WriteLine("R: Read a name from the array.");
                Console.WriteLine("U: Change a name in the array.");
                Console.WriteLine("D: Remove a name from the array.");
                Console.WriteLine("Sort: Sort the names alphabetcially.");
                Console.WriteLine("Q: Quit the program.");
                    
                //get a valid user option from the menu

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" 
                                || userChoiceString=="S" || userChoiceString=="s"
                                || userChoiceString=="C"|| userChoiceString=="c"
                                || userChoiceString=="R"|| userChoiceString=="r"
                                || userChoiceString=="U"|| userChoiceString=="u"
                                || userChoiceString=="D"|| userChoiceString=="d"
                                || userChoiceString=="Q"|| userChoiceString=="q"
                                || userChoiceString=="Sort");

                if (!userChoice) //if not valid tell to enter valid option
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            } while (!userChoice); //while user choice is not valid 
        
        //if the option is L or l then load the text file (names.txt) into the array of strings (nameArray)
            
            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("In the L/l area.");
                index=0;
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of the file mytest.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        nameArray[index]=s;
                        index=index+1;
                        if (index==nameArray.Length)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("");
                }
            }

        //if the option is S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                Console.WriteLine("In the S/s area.");
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                         
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName)) 
                {
                    for (index=0;index<nameArray.Length;index++)
                    {
                        fileStr.WriteLine(nameArray[index]);
                    }
                }
                Console.WriteLine(fileName + " has been saved.");
            }
        
        //if the option is C or c then add a name to the array of strings (if there is room)
            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area."); //repeated because there was 2 open spaces??
                int spaceIndex;
                string newName;
                bool spaceBool=false;
                int foundIndex = -1;
                
                do{
                    //for (index=0;index<nameArray.Length;index++)
                    foundIndex=Search(nameArray,"");
                    {
                        if (foundIndex!=-1)
                        {
                            Console.WriteLine("There is a blank space at " + foundIndex + " index.");
                            Console.WriteLine("Enter the new name to add.");
                            newName = Console.ReadLine();
                            nameArray[foundIndex]=newName;
                            Console.WriteLine($"{nameArray[foundIndex]} has been added at position {foundIndex}.");
                            spaceBool=true;
                        };
                    }  
                    if (spaceBool==false)
                        {
                            Console.WriteLine("There is no space in the array. Delete a name first.");
                            break;           
                        }
                }while (foundIndex == -1);
            }
        
        //if the option is R or r then print the array
            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area.");
                for (index =0;index<10;index++)
                {
                    Console.WriteLine(nameArray[index]);
                }
            }
        
        //if the option is U or u then update a name in the array (if it is there)
        
            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area.");
                string currentName;
                string newName;
                int foundIndex = -1;
                int numChanges =0;
                //determine if name is in array
                do
                {
                    Console.WriteLine("Enter the name you want to update. Or enter \"Cancel\" to return to the main menu.");
                    currentName=Console.ReadLine();
                    //if user enters "Cancel", breaks out of the loop back to the main menu!
                    if (currentName == "Cancel")
                    {
                        break;
                    }
                    //if the user enters anything other than Cancel it searches again
                    else
                    {
                        foundIndex = Search(nameArray,currentName);
                        //if name is found, prmpt for new name
                        if(foundIndex !=-1)
                        {
                            Console.WriteLine("Enter the new name.");
                            newName=Console.ReadLine();
                            //while the name is still found, update it
                            while (foundIndex != -1)
                            {
                                //update name in array
                                nameArray[foundIndex]=newName;
                                //write the position it was updated
                                Console.WriteLine($"{currentName} has been updated at position {foundIndex}");
                                //track number of times it was updated
                                numChanges++;
                                //search again
                                foundIndex = Search(nameArray,currentName);
                            }
                            //indicate how many times it was updated
                            Console.WriteLine($"{currentName} has been updated to {newName} {numChanges} times.");
                        }
                        //if name not found
                        else if (foundIndex == -1)
                            {
                                Console.WriteLine($"{currentName} not found. Which name do you want to update?");
                            };
                    }
                }while (currentName!="Cancel");
            }
            
        
        //else if the option is D or d then delete a name in the array (if it is there)
            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area.");
                string deleteName;
                int foundIndex=-1;
                bool deleted = false;

                //determine if name is in array
                Console.WriteLine("Which name do you want to delete?");
                
                //prompt for existing name to change
                deleteName=Console.ReadLine();
                foundIndex=Search(nameArray,deleteName);
                for (int i=0;i<nameArray.Length;i++)
                    {
                        if (foundIndex!=-1)
                        {
                            Console.WriteLine($"{deleteName} is at postion {foundIndex}.");
                            //update name in array
                            nameArray[foundIndex]="";
                            Console.WriteLine($"{deleteName} has been deleted from position {foundIndex}.");
                            foundIndex=Search(nameArray,deleteName);
                            deleted=true;
                        }
                    }
                if (foundIndex==-1 && deleted==false)
                    {
                        Console.WriteLine($"{deleteName} not found. Which name do you want to delete?");
                    }; 
            }
        
            else if (userChoiceString=="Sort")
            {
                Array.Sort(nameArray);
                foreach(string name in nameArray)
                {
                    Console.WriteLine(name);
                }
            }

        //else if the option is Q or q then quit the program 
            else 
            {
                Console.WriteLine("Goodbye.");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
    } //end main
  } //end program
} //end namespace
