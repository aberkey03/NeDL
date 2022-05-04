using System;
namespace RestaurantRater 
{
    class Program
  {
        static int GetValueInRange (int minVal1, int maxVal1, string variableName1) 
        //MinVal1 = minimum value
        //MaxVal1 = maxium value
        //variableName = name of value to check
        //if valid, return val1 
        //if invalid prompt for another entry
        {
            int val1; 
            do
            {
                Console.WriteLine("Enter " + variableName1 + "." + " " + variableName1 + " must be greater than " + minVal1 + " and less than " + maxVal1 +"." );
                val1 = Convert.ToInt32(Console.ReadLine());
            }while (val1 < minVal1 || val1 >maxVal1);
            //repeat while less than min, or more than max
            return val1;
        }
        static int search(string[] arr, string x)
        {
            int n = arr.Length;
            for (int i = 0; i<n;i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            //TODO prompt with menu
            // DECLARE vARRIABLES
            bool userChoice;
            string userChoiceString;
            int restaurantNum = 25;
            int ratingNum = 1;
            string[,] restaurantArray = new string [restaurantNum,ratingNum];
            string fileName = "restaurantsRatings.txt";
            string restaurantName = "";
            string restaurantRating = "";
            do  //repeat the main loop until Q is entered 
            {
                //get a valid option
                do
                {
                    //display menu of options
                    userChoice = false; //set to false so this will run initally 
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("O: Open the list of restaurants.");
                    Console.WriteLine("S: Save the list of restaurants.");
                    Console.WriteLine("C: Add a restaurant.");
                    Console.WriteLine("R: Read the list of restaurants.");
                    Console.WriteLine("U: Change a restaurant name or rating.");
                    Console.WriteLine("D: Remove a restaurant from the list.");
                    Console.WriteLine("Q: Quit the program.");
                        
                    //get a valid user option from the menu
                    userChoiceString = Console.ReadLine();
                    userChoice = (userChoiceString=="O" || userChoiceString=="o" 
                                    || userChoiceString=="S" || userChoiceString=="s"
                                    || userChoiceString=="C"|| userChoiceString=="c"
                                    || userChoiceString=="R"|| userChoiceString=="r"
                                    || userChoiceString=="U"|| userChoiceString=="u"
                                    || userChoiceString=="D"|| userChoiceString=="d"
                                    || userChoiceString=="Q"|| userChoiceString=="q");
                    if (!userChoice) //if not valid tell to enter valid option
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } while (!userChoice); //while user choice is not valid 

                // if the option is O or o then load the text file (fileName) into the array
                if (userChoiceString=="O" || userChoiceString=="o")
                {
                Console.WriteLine("In the L/l area.");
                int index=0;
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of the file mytest.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        restaurantArray[index]=s;
                        index=index+1;
                        if (index==10)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("");
                }
            }

                //TODO else if the option is S or s then store the array of strings into the text file
                else if (userChoiceString=="S" ||userChoiceString=="s")
                {
                    Console.WriteLine("IN THE S AREA");
                }
                    //TODO if array not loaded, throw error

                //TODO else if the option is C or c then add a retaurant and rating to the array of strings (if there is room)
                    //TODO if array not loaded, throw error
                 else if (userChoiceString=="C" ||userChoiceString=="c")
                {
                    Console.WriteLine("IN THE C AREA");
                }
                //TODO else if the option is R or r then print the array
                    //TODO if array not loaded, throw error
                else if (userChoiceString=="R" ||userChoiceString=="r")
                {
                    Console.WriteLine("IN THE R AREA");
                    
                }
                //TODO else if the option is U or u then update a name in the array (if it is there)
                    //TODO if array not loaded, throw error
                else if (userChoiceString=="U" ||userChoiceString=="u")
                {
                    Console.WriteLine("IN THE U AREA");
                }
                //TODO else if the option is D or d then delete a name in the array (if it is there)
                    //TODO if array not loaded, throw error
                else if (userChoiceString=="D" ||userChoiceString=="d")
                {
                    Console.WriteLine("IN THE D AREA");
                }
                //TODO else if the option is Q or q then quit the program
                else
                {
                    Console.WriteLine("Goodbye.");
                }

            }while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
        } //end main
    } //end class
} //end namespace