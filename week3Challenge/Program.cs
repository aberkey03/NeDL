 
using System;

namespace EmployeeBonuses
{
    class Program
    {
        static void Main (string[] args)
        {
           //test individual class constructors and ToStrings

            //test empty Employee Constructor
            Employee testEmployee1 = new Employee();
            Console.WriteLine(testEmployee1);

            //test 'standard' Employee Constructor 
            Employee testEmployee2 = new Employee("Employee", "Test", 'E');
            Console.WriteLine(testEmployee2);
            
            //test empty HourlyEmployee Constructor
            HourlyEmployee testHourlyEmployee1 = new HourlyEmployee();
            Console.WriteLine(testHourlyEmployee1);

            //test 'standard' HourlyEmployee Constructor
            HourlyEmployee testHourlyEmployee2 = new HourlyEmployee("Employee", "Hourly", 'H', 25.00);
            Console.WriteLine(testHourlyEmployee2);

            //test empty SalaryEmployee Constructor
            SalaryEmployee testSalaryEmployee1 = new SalaryEmployee();
            Console.WriteLine(testSalaryEmployee1);

            //test 'standard' SalaryEmployee Constructor
            SalaryEmployee testSalaryEmployee2 = new SalaryEmployee("Employee", "Salary", 'S', 80000);
            Console.WriteLine(testSalaryEmployee2);
            
            //write blank line to seperate testing
            Console.WriteLine("");

            // initialize array of Employees
            Employee [] employeeArray = new Employee [20];
            
            employeeArray[0] = testEmployee2;
            employeeArray[1] = testHourlyEmployee2;
            employeeArray[3] = testSalaryEmployee2;

            //loop through array and print only those with data
            //reuse for R
            for (int index = 0; index < employeeArray.Length; index++)
            {
                if(!(employeeArray[index]==null))
                {
                    Console.WriteLine(employeeArray[index]);
                }
            }
            
            //initialize main variables 
            string userChoiceString; //main menue entry
            bool userChoice;  //flag for valid main menue entry


            do //main loop, continues until Q is entered 
            {
                
                do //get a valid option, continues until userChoice == true
                {
                    //display menu of options
                    userChoice = false; //set to false so this will run initally 
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("L: Load the data file into the array.");
                    Console.WriteLine("S: Store the array into the file.");
                    Console.WriteLine("C: Add a name into the array.");
                    Console.WriteLine("R: Read a name from the array.");
                    Console.WriteLine("U: Change a name in the array.");
                    Console.WriteLine("D: Remove a name from the array.");
                    Console.WriteLine("Q: Quit the program.");
                        
                    //get a valid user option from the menu
                    userChoiceString = Console.ReadLine();
                    userChoice = (userChoiceString=="L" || userChoiceString=="l" 
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

                //if the option is L or l then load the text file  into the array 
                if (userChoiceString=="L" || userChoiceString=="l")
                {
                    Console.WriteLine("In the L/l area.");
                    /* index=0;
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        Console.WriteLine("Here is the content of the file mytest.txt: ");
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                            nameArray[index]=s;
                            index=index+1;
                            if (index==10)
                            {
                                break;
                            }
                        }
                        Console.WriteLine("");
                    } */
                }

                //else if the option is S or s then store the array of strings into the text file
                else if (userChoiceString=="S" || userChoiceString=="s")
                {
                    Console.WriteLine("In the S/s area.");
                    /* // Delete the file if it exists.
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
                    Console.WriteLine(fileName + " has been saved."); */
                }

                //if the option is C or c then add a name to the array of strings (if there is room)
                else if (userChoiceString=="C" || userChoiceString=="c")
                {
                    Console.WriteLine("In the C/c area."); 
                    //int spaceIndex=0;
                    //string newName;
                    bool spaceBool=false;
                    
                    do{
                        for (int index = 0 ; index < employeeArray.Length;index++)
                        {
                            if (employeeArray[index]==null)
                            {
                                //spaceIndex=index;

                                //confirm there is a blank space in the array
                                Console.WriteLine("There is a blank space at position " + index + ".");
                                
                                //get LastName
                                Console.WriteLine("Enter the new employee's last name.");
                                string newEmployeeLastName = Console.ReadLine();
                                //get FirstName
                                Console.WriteLine("Enter the new employee's first name.");
                                string newEmployeeFirstName = Console.ReadLine();
                                
                                Console.WriteLine("Enter the new employee's employee type (H or S).");
                                char newEmplpoyeeType = Convert.ToChar(Console.ReadLine());
                                if (newEmplpoyeeType == 'S')
                                {
                                    Console.WriteLine("Enter the new employee's salary.");
                                    int newSalary = Convert.ToInt32(Console.ReadLine());
                                    employeeArray[index] = new SalaryEmployee(newEmployeeLastName, newEmployeeFirstName, newEmplpoyeeType, newSalary);
                                    Console.WriteLine();
                                    Console.WriteLine(employeeArray[index]);
                                    Console.WriteLine();
                                }
                                else if (newEmplpoyeeType == 'H')
                                {
                                    Console.WriteLine("Enter the new employee's hourly rate.");
                                    double newHourlyRate = Convert.ToDouble(Console.ReadLine());
                                    employeeArray[index] = new HourlyEmployee(newEmployeeLastName, newEmployeeFirstName, newEmplpoyeeType, newHourlyRate);
                                    Console.WriteLine();
                                    Console.WriteLine(employeeArray[index]);
                                    Console.WriteLine();
                                }
                                //employeeArray[index]=newName;
                                //Console.WriteLine(employeeArray[index] + "Has been added at position " + index + ".");
                                spaceBool=true;
                                break;
                            };
                        }  
                        if (spaceBool==false)
                            {
                                Console.WriteLine("There is no space in the array. Delete an employee first.");
                                break;           
                            }
                    }while (!spaceBool); 
                }

                //if the option is R or r then print the array
                else if (userChoiceString=="R" || userChoiceString=="r")
                {
                    Console.WriteLine("In the R/r area.");
                    //loop through array and print only those with data
                    for (int i = 0; i < employeeArray.Length; i++)
                    {
                        if(!(employeeArray[i]==null))
                        {
                            Console.WriteLine(employeeArray[i]);
                        }
                    }
                }
        
                //if the option is U or u then update a name in the array (if it is there)
                else if (userChoiceString=="U" || userChoiceString=="u")
                {
                    Console.WriteLine("In the U/u area.");
                    /* string currentName;
                    string newName;
                    int result = -1;
                    int [] arrPosition = new int {0};
                    //determine if name is in array
                    Console.WriteLine("Which name do you want to update?");
                    do
                    {
                        //prompt for existing name to change
                        currentName=Console.ReadLine();
                        result = search(nameArray,currentName);
                        if (result !=-1)
                        {
                            int [] arrPosition = new int {result};
                        }
                        if (result  ==-1)
                        {
                            Console.WriteLine($"{currentName} not found. Which name do you want to update?");
                        }
                    }while(result == -1);
                    Console.WriteLine("Name found. Enter new name.");
                    newName=Console.ReadLine();
                    foreach (int result in arrPosition)
                    {
                        nameArray[result]=newName;
                    }
                    Console.WriteLine($"{currentName} has been updated to {newName} {arrPosition.Length} times."); */
                }
        
                //else if the option is D or d then delete a name in the array (if it is there)
                else if (userChoiceString=="D" || userChoiceString=="d")
                {
                    Console.WriteLine("In the D/d area.");
                    /* string deleteName;
                    bool nameFound=false;
                    //determine if name is in array
                    Console.WriteLine("Which name do you want to delete?");
                    do
                    {
                        //prompt for existing name to change
                        deleteName=Console.ReadLine();
                        for (index =0;index<10;index++)
                        {
                            if (nameArray[index]==deleteName)
                            {
                                nameFound=true;
                                Console.WriteLine($"{deleteName} is at postion {index}.");
                                //update name in array
                                nameArray[index]="";
                                Console.WriteLine($"{deleteName} has been deleted from position {index}.");
                                break;
                            }
                        }
                        if (nameFound==false)
                        {
                            Console.WriteLine($"{deleteName} not found. Which name do you want to delete?");
                        };
                    }while(!(nameFound)); */
                }
        
                //else if the option is Q or q then quit the program 
                else 
                {
                    Console.WriteLine("Goodbye.");
                }

            } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));


        }  //end main
    }  //end program
}  //end namespace