using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class Program
  {
    static int Search(string[] arr, int arrLength, string x, string y)
    {
        for (int i =0; i<arrLength; i++)
        {
            if ((arr[i] == x) || (arr[i] == y))
                return i;
        }
        return -1;
    }
    static bool IsEmpty(string[]arr, bool flag)
    {
        int ctr=0;
        for (int i =0; i < arr.Length; i++)
        {
            if (arr[i]==null || arr[i]=="")
            {
                ctr++;
            }
        };
        if (ctr == 0)
        {
            flag=false;
        }
        else 
        {
            flag = true;
        }
        Console.WriteLine(flag);
        return flag;
    }
    static int GetValidInt(int maxVal, int minVal)
    {
      int val1;
      do
      {
        val1 = Convert.ToInt32(Console.ReadLine()); //get value
        if (val1 < minVal || val1 > maxVal)
        {
            Console.WriteLine("Rating  must be between 0-5.");
        }
      }
      while //val1 is invalid
        (val1 < minVal || val1 > maxVal);
        
        return val1; //if val1 is valid
    }
    static void Main(string[] args)
    {
        // DECLARE vARRIABLES
        bool userChoice;
        string userChoiceString;
        int arrayLength = 25;
        Restaurant[] restaurantArray=new Restaurant[arrayLength];
        for (int i = 0; i < restaurantArray.Length; i++)
        {
            restaurantArray[i]= new Restaurant();
        }
        string[] restName = new string[arrayLength];
        string[] restRate = new string[arrayLength];
        
        int index = 0; //this is the index for the array
        string fileName = "restaurantRatings.txt";

        //repeat the main loop until Q is entered 
        do
        {
            //get a valid option
            do
            {
                //display menu of options
                userChoice = false; //set to false so this will run initally 
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("O: Open the data file.");
                Console.WriteLine("S: Store the array into the file.");
                Console.WriteLine("C: Add a restaurant name and rating.");
                Console.WriteLine("R: Read the list of restaurants and ratings.");
                Console.WriteLine("U: Change a restaurant name or rating.");
                Console.WriteLine("D: Remove a restaurant name and rating.");
                Console.WriteLine("Q: Quit the program.");
                    
                //get a valid user option from the menu

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="O" || userChoiceString=="o" 
                                || userChoiceString=="S" || userChoiceString=="s"
                                || userChoiceString=="C"|| userChoiceString=="c"
                                || userChoiceString=="R"|| userChoiceString=="r"
                                || userChoiceString=="U"|| userChoiceString=="u"
                                || userChoiceString=="D"|| userChoiceString=="d"
                                || userChoiceString=="Q"|| userChoiceString=="q"
                                );

                if (!userChoice) //if not valid tell to enter valid option
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            } while (!userChoice); //while user choice is not valid 
        
         // if the option is O or o then load the text file (names.txt) into the array of strings (nameArray)
            if (userChoiceString=="O" || userChoiceString=="o")
            {
                Console.WriteLine("In the O/o area.");
                index=0;
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string rName = "";
                    int rRate = -1;
                    Console.WriteLine($"Here is the content of the file {fileName}: ");
                    while ((rName = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(rName);
                        restaurantArray[index].RName=rName;
                        
                        rRate=Convert.ToInt16(sr.ReadLine());
                        Console.WriteLine(rRate);
                        restaurantArray[index].RRate=rRate;
                        
                        index=index+1;
                        if (index==arrayLength)
                        {
                            break;
                        }
                    }
                }
            }

         // else if the option is S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                Console.WriteLine("In the S/s area.");
                //bool e=false;
                //IsEmpty(restName,e);
                //if (e==false)
                //{
                //    Console.WriteLine("There are not restaurants or ratings on the list. Add a restaurant before saving the file.");
                //}
                //else
                //{
                    // Delete the file if it exists.
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }
                            
                    // Create the file.
                    using (StreamWriter fileStr = File.CreateText(fileName)) 
                    {
                        string rName = "";
                        int rRate = -1;
                        for (index=0;index<restaurantArray.Length;index++)
                        {
                            if ((rName = restaurantArray[index].RName)!=null)
                            fileStr.WriteLine(restaurantArray[index].RName);
                            if ((rRate = restaurantArray[index].RRate)!=-1)
                            fileStr.WriteLine(restaurantArray[index].RRate);
                        }
                    }
                    Console.WriteLine(fileName + " has been saved.");
                //}
            }
        
         // else if the option is C or c then add a name to the array of strings (if there is room)
            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area."); 
                int spaceIndex;
                string rName;
                int rRate;
                bool spaceBool=false;
                int foundIndex = -1;
                //bool e = false;

                //IsEmpty(restName,e);
                //if (e==false)
                //{
                //    Console.WriteLine("The file must be opened before new restaurants can be added.");
                //}
                //else
                //{
                    do{
                        foundIndex=Search(restName,arrayLength, null, "");
                        {
                            if (foundIndex!=-1)
                            {
                                Console.WriteLine("There is a blank space.");
                                Console.WriteLine("Enter the new restaurant to add.");
                                rName = Console.ReadLine();
                                restaurantArray[foundIndex].RName=rName;
                                Console.WriteLine($"Enter the rating (0-5) for {rName}.");
                                // validate rating 0-5
                                rRate = GetValidInt(6,-1);
                                restaurantArray[foundIndex].RRate=rRate;
                                spaceBool=true;
                            };
                        }  
                        if (spaceBool==false)
                            {
                                Console.WriteLine("There is no space. Delete a restaurant first.");
                                break;           
                            }
                    }while (foundIndex == -1);
                //}
            }
        
        // esle if the option is R or r then print the array
            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area.");
                //bool e = true;
                //IsEmpty(restName,e);
                //if (e==true)
                //{
                //    Console.WriteLine("The file must be opened before the restaurants and ratings can be read.");
                //}
                //else
                //{
                    for (index =0;index<arrayLength;index++)
                    {
                        if (restaurantArray[index].RRate!=-1)
                        {
                            Console.WriteLine(restaurantArray[index].ToString());
                        }
                    }
                //}
            }
        
        // TODO else if the option is U or u then update a name in the array (if it is there)
        
            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area.");
                string rNameCurrent;
                string rNameNew;
                string rRateCurrent;
                string rRateNew;
                int foundIndex = -1;
                int numChanges = 0;
                
                bool e = false;
                IsEmpty(restName,e);
                if (e==false)
                {
                    Console.WriteLine("The file must be opened before adding a new restaurant.");
                }
                else
                {
                    //determine if name is in array
                    do
                    {
                        Console.WriteLine("Enter the restaurant you want to update. Or enter \"Cancel\" to return to the main menu.");
                        rNameCurrent=Console.ReadLine();
                        //if user enters "Cancel", breaks out of the loop back to the main menu!
                        if (rNameCurrent == "Cancel")
                        {
                            break;
                        }
                        //if the user enters anything other than Cancel, search 
                        else
                        {
                            foundIndex = Search(restName, restName.Length, rNameCurrent, rNameCurrent);
                            //if name is found, prmpt for new name
                            if(foundIndex !=-1)
                            {
                                Console.WriteLine("Enter the new restaurant name.");
                                rNameNew=Console.ReadLine();
                                Console.WriteLine($"Enter the new rating for {rNameNew}.");
                                rRateNew=Console.ReadLine();
                                //while the name is still found, update it
                                while (foundIndex != -1)
                                {
                                    //update name in array
                                    restName[foundIndex]=rNameNew;
                                    restRate[foundIndex]=rRateNew;
                                    //write the position it was updated
                                    Console.WriteLine($"{rNameCurrent} has been updated at position {foundIndex}");
                                    //track number of times it was updated
                                    numChanges++;
                                    //search again
                                    foundIndex = Search(restName, restName.Length, rNameCurrent, rNameCurrent);
                                }
                                //indicate how many times it was updated
                                Console.WriteLine($"{rNameCurrent} has been updated to {rNameNew} and rated {rRateNew}, {numChanges} times.");
                            }
                            //if name not found
                            else if (foundIndex == -1)
                                {
                                    Console.WriteLine($"{rNameCurrent} not found. Which name do you want to update?");
                                };
                        }
                    }while (rNameCurrent!="Cancel");
                }
            }
            
        
        // TODO else if the option is D or d then delete a name in the array (if it is there)
            
            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area.");
                string rNameDelete;
                string rRateDelete;
                int foundIndex=-1;
                bool deleted = false;
                bool e = false;
                
               
                if (IsEmpty(restName,e)==false)
                {
                    Console.WriteLine("The file must be opened before deleting restaurant.");
                }
                else
                {
                    //determine if name is in array
                    Console.WriteLine("Which name do you want to delete?");
                    while (deleted==false)
                    {
                        //prompt for existing name to change
                        rNameDelete=Console.ReadLine();
                        foundIndex=Search(restName,restName.Length,rNameDelete,rNameDelete);
                        for (int i=0;i<restName.Length;i++)
                            {
                                if (foundIndex!=-1)
                                {
                                    Console.WriteLine($"{rNameDelete} is at postion {foundIndex}.");
                                    //update name in array
                                    restName[foundIndex]="";
                                    restRate[foundIndex]="";
                                    Console.WriteLine($"{rNameDelete} has been deleted from position {foundIndex}.");
                                    foundIndex=Search(restName,restName.Length,rNameDelete,rNameDelete);
                                    deleted=true;
                                }
                            }
                        if (foundIndex==-1 && deleted==false)
                            {
                                Console.WriteLine($"{rNameDelete} not found. Which name do you want to delete?");
                            }; 
                    }
                }
            }

        //else if the option is Q or q then quit the program 
            else 
            {
                Console.WriteLine("Goodbye.");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
    } //end main, ended again
  } //end program
} //end namespace
