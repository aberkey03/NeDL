using System;

namespace CustomerMemberships
{
    class Program
    {
        static int Search(List<MembershipGeneric> membershipList)
        {
            bool membershipFound = false;
            int result = -1;
            do
            {
                Console.WriteLine("Enter the membership ID");
                int searchMembershipID = Convert.ToInt32(Console.ReadLine());
                for (int index = 0; index < membershipList.Count; index++)
                {
                    if (membershipList[index].MembershipID == searchMembershipID)
                    {
                        Console.WriteLine("Membership found.");
                        Console.WriteLine(membershipList[index]);
                        membershipFound = true;
                        result = membershipList[index].MembershipID;
                    }
                }
                if (membershipFound != true)
                {
                    Console.WriteLine("Account not found");
                    Console.WriteLine("Would you like to search again? (Y/N)");
                    char searchAgain = Convert.ToChar(Console.ReadLine());
                    if (searchAgain == 'N')
                    {
                        Console.WriteLine("Search canceled. Returning to main menu.");
                        membershipFound = true; // should break out of the search loop
                    } 
                }
            } while (!membershipFound);
            return result;
        }

        static int GetPositiveInt (int minVal, string variableName) 
        //minVal = minimum value
        //if valid, return val1 
        //if invalid prompt for another entry
        {
            int val; //var for user entry
            do
            {
                Console.WriteLine("Enter " + variableName + "." + " " + variableName + " must be greater than " + minVal + ".");
                val = Convert.ToInt32(Console.ReadLine());
            }
            //repeat while less than min
            while (val <= minVal);
            return val;
        }

        static void Main(string[] args)
        {
            /* Console.WriteLine("Regular");
            Regular regular1 = new Regular(1000, "regular1@gmail.com", "Regular", 100.00, 300.00);
            Console.WriteLine(regular1);

            Console.WriteLine("After purchase");
            regular1.Purchase(50);
            Console.WriteLine(regular1);

            Console.WriteLine("After return");
            regular1.Return(100);
            Console.WriteLine(regular1);

            Console.WriteLine("Cash back");
            regular1.ApplyCashBack(); */

            /* Console.WriteLine("Executive");
            Executive executive1 = new Executive(2000, "executive1@gmail.com", "Executive", 200, 700);
            Console.WriteLine(executive1);

            Console.WriteLine("After purchase");
            executive1.Purchase(50);
            Console.WriteLine(executive1);

            Console.WriteLine("After return");
            executive1.Return(100);
            Console.WriteLine(executive1);

            Console.WriteLine("Cash back");
            executive1.ApplyCashBack();

            Console.WriteLine("Executive2");
            Executive executive2 = new Executive(2001, "executive2@gmail.com", "Executive", 200, 2000);
            Console.WriteLine(executive2);

            Console.WriteLine("Cash back");
            executive2.ApplyCashBack(); */

            /* Console.WriteLine("NonProfit, Military/Education");
            NonProfit nonProfit1 = new NonProfit(3000, "nonProfit1@gmail.com", "NonProfit", true, 50.00, 300.00);
            Console.WriteLine(nonProfit1);

            Console.WriteLine("After purchase");
            nonProfit1.Purchase(50);
            Console.WriteLine(nonProfit1);

            Console.WriteLine("After return");
            nonProfit1.Return(100);
            Console.WriteLine(nonProfit1);

            Console.WriteLine("Cash back");
            nonProfit1.ApplyCashBack();

            Console.WriteLine("NonProfit, Non-Military/Education");
            NonProfit nonProfit2 = new NonProfit(3001, "nonProfit2@gmail.com", "NonProfit", false, 50.00, 300.00);
            Console.WriteLine(nonProfit2);

            Console.WriteLine("After purchase");
            nonProfit2.Purchase(50);
            Console.WriteLine(nonProfit2);

            Console.WriteLine("After return");
            nonProfit2.Return(100);
            Console.WriteLine(nonProfit2);

            Console.WriteLine("Cash back");
            nonProfit2.ApplyCashBack(); */

            /* Console.WriteLine("Corporate");
            Corporate corporate1 = new Corporate(4000, "corporate1@gmail.com", "Corporate", 200, 6537.37);
            Console.WriteLine(corporate1);

            Console.WriteLine("After purchase");
            corporate1.Purchase(1000);
            Console.WriteLine(corporate1);

            Console.WriteLine("After return");
            corporate1.Return(2000);
            Console.WriteLine(corporate1);

            Console.WriteLine("Cash back");
            corporate1.ApplyCashBack(); */

            // TEST DATA
            Regular regular1 = new Regular(1000, "regular1@gmail.com", "Regular", 100.00, 300.00);
            Executive executive1 = new Executive(2000, "executive1@gmail.com", "Executive", 200, 700);
            Executive executive2 = new Executive(2001, "executive2@gmail.com", "Executive", 200, 2000);
            NonProfit nonProfit1 = new NonProfit(3000, "nonProfit1@gmail.com", "NonProfit", true, 50.00, 300.00);
            NonProfit nonProfit2 = new NonProfit(3001, "nonProfit2@gmail.com", "NonProfit", false, 50.00, 300.00);
            Corporate corporate1 = new Corporate(4000, "corporate1@gmail.com", "Corporate", 200, 6537.37);

            // CREATE LIST AND ADD TEST DATA
            List<MembershipGeneric> membershipList = new List<MembershipGeneric>();
            membershipList.Add(regular1);
            membershipList.Add(executive1);
            membershipList.Add(executive2);
            membershipList.Add(nonProfit1);
            membershipList.Add(nonProfit2);
            membershipList.Add(corporate1);

            Search(membershipList);
            
            // INTERFACE 

            // INITIAL VARIABLES
            bool validMainMenuChoice;
            string mainMenuChoice;
            do // keep program running until 'Q' is entered
            {
                do // keep at main menu until a valid option is entered 
                {
                    validMainMenuChoice = false;
                    
                    //display options
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("MAIN MENU");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("C - Create a new membership and add to the membership list.");
                    Console.WriteLine("R - Read all of the memberships in the membership list.");
                    Console.WriteLine("U - Update an existing membership based on membership ID.");
                    Console.WriteLine("D - Delete an existing membership based on membership ID.");
                    Console.WriteLine("L - List all of the memberships in the list including all of the information for each account type.");
                    Console.WriteLine("P - Perform a purchase transaction by getting a membership number from the user and a purchase amount and if the membership exists add the purchase amount to the monthly purchase total.");
                    Console.WriteLine("T - Perform a return transaction by getting an membership number from the user and a return amount and if the membership exists, perform the return by subtracting the return amount for the monthly purchase total.");
                    Console.WriteLine("A - Apply cash-back rewards as described above by getting a membership number from the user.");
                    Console.WriteLine("Q - Quit the transaction processing.");

                    
                    //read user entry, and verify it is valid
                    mainMenuChoice = Console.ReadLine();
                    validMainMenuChoice = (mainMenuChoice == "C" || mainMenuChoice == "c" 
                        || mainMenuChoice == "R" || mainMenuChoice == "r" 
                        || mainMenuChoice == "U" || mainMenuChoice == "u" 
                        || mainMenuChoice == "D" || mainMenuChoice == "d"
                        || mainMenuChoice == "L" || mainMenuChoice == "l"
                        || mainMenuChoice == "P" || mainMenuChoice == "p"
                        || mainMenuChoice == "T" || mainMenuChoice == "t"
                        || mainMenuChoice == "A" || mainMenuChoice == "a"
                        || mainMenuChoice == "Q" || mainMenuChoice == "q");
                    //if not valid tell to enter valid option
                    if (!validMainMenuChoice) 
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } while (!validMainMenuChoice);
                
                /* C - Create a new membership and add to the membership list.  
                Be sure you don't duplicate the membership ID.  It needs to be unique. */
                if (mainMenuChoice == "C" || mainMenuChoice == "c")
                {
                    Console.WriteLine("You selected C - Create a new membership and add to the membership list.");
                
                    //check if MembershipID is already in use before gathering other details
                    //loops until an unused ID is entered
                    bool membershipFound = true;
                    int newMembershipID;
                    do
                    {
                        Console.WriteLine("Enter the new membership ID.");
                        newMembershipID = Convert.ToInt32(Console.ReadLine());
                        foreach (MembershipGeneric membershipDetails in membershipList)
                        {
                            if (membershipDetails.MembershipID == newMembershipID)
                            {
                                membershipFound = true;
                                break;
                            }
                            else 
                            {
                                membershipFound = false;
                            }
                        }
                        if (membershipFound == true)
                        {
                            Console.WriteLine($"Membership ID {newMembershipID} is already in use.");
                        }
                    }while (membershipFound == true);
                    
                    //gather new membership details 
                    Console.WriteLine("What type of membership would you like to add?");
                    string newMembershipType = Console.ReadLine();

                    Console.WriteLine("Enter the primary email address.");
                    string newPrimaryEmailAddress = Console.ReadLine();

                    Console.WriteLine("Enter the annual membership cost.");
                    double newAnnualCost = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the total monthly purchase amount.");
                    double newPuchasesMonthly = Convert.ToDouble(Console.ReadLine());

                    //add new membership to the list
                    switch (newMembershipType)
                    {
                        case "Regular":
                        {
                            membershipList.Add(new Regular(newMembershipID, newPrimaryEmailAddress, newMembershipType, newAnnualCost, newPuchasesMonthly));
                            break;
                        }
                        case "Executive":
                        {
                            membershipList.Add(new Executive(newMembershipID, newPrimaryEmailAddress, newMembershipType, newAnnualCost, newPuchasesMonthly));
                            break;
                        }
                        case "Non-Profit":
                        // determine if the non-profit a military or educational organization, and set the newMilitaryEducation bool value accordingly
                        {
                            bool newMilitaryEducation;
                            Console.WriteLine("Is the non-profit a military or educational organization? (Y/N)");
                            string miliaryEducationResponse = Console.ReadLine();

                            if (miliaryEducationResponse == "N")
                            {
                                newMilitaryEducation = false;
                                membershipList.Add(new NonProfit(newMembershipID, newPrimaryEmailAddress, newMembershipType, newMilitaryEducation, newAnnualCost, newPuchasesMonthly));
                            }
                            else if (miliaryEducationResponse == "Y")
                            {
                                newMilitaryEducation = true;
                                membershipList.Add(new NonProfit(newMembershipID, newPrimaryEmailAddress, newMembershipType, newMilitaryEducation, newAnnualCost, newPuchasesMonthly));
                            }
                            break;
                        }
                        case "Corporate":
                        {
                            membershipList.Add(new Corporate(newMembershipID, newPrimaryEmailAddress, newMembershipType, newAnnualCost, newPuchasesMonthly));
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Enter a valid membership type");
                            break;
                        }
                    } //end newMembershipType switch
                } //end C

                /* R - Read all of the memberships in the membership list.
                same as L */
                if (mainMenuChoice == "R" || mainMenuChoice == "r")
                {
                    Console.WriteLine("You selected R - Read all of the memberships in the membership list.");

                    foreach (MembershipGeneric membershipDetails in membershipList)
                    {
                        Console.WriteLine(membershipDetails);
                    }
                } //end R

                /* U - Update an existing membership based on membership ID. */
                if (mainMenuChoice == "U" || mainMenuChoice == "u")
                {
                    Console.WriteLine("You selected U - Update an existing membership primary email address based on membership ID.");
                    bool membershipFound = false;
                    do
                    {
                        Console.WriteLine("Enter the membership ID");
                        int searchMembershipID = Convert.ToInt32(Console.ReadLine());
                        for (int index = 0; index < membershipList.Count; index++)
                        {
                            if (membershipList[index].MembershipID == searchMembershipID)
                            {
                                Console.WriteLine("Membership found. Enter the new email address.");
                                string ?newPrimaryEmailAddress = Console.ReadLine();
                                membershipList[index].PrimaryEmailAddress = newPrimaryEmailAddress;
                                Console.WriteLine("The email address has been updated.");
                                membershipFound = true;
                            }
                        }
                        if (membershipFound != true)
                        {
                            Console.WriteLine("Account not found");
                            Console.WriteLine("Would you like to search again? (Y/N)");
                            string ?searchAgain = Console.ReadLine();
                            if (searchAgain == "N" || searchAgain == "n")
                            {
                                Console.WriteLine("Search canceled. Returning to main menu.");
                                break; // break out of the search loop
                            }
                        }
                    } while (!membershipFound);
                } //end U

                /* D - Delete an existing membership based on membership ID. */
                if (mainMenuChoice == "D" || mainMenuChoice == "d")
                {
                    Console.WriteLine("You selected D - Delete an existing membership based on membership ID.");

                    bool membershipFound = false;
                    do
                    {
                        Console.WriteLine("Enter the membership ID");
                        int searchMembershipID = Convert.ToInt32(Console.ReadLine());
                        for (int index = 0; index < membershipList.Count; index++)
                        {
                            if (membershipList[index].MembershipID == searchMembershipID)
                            {
                                Console.WriteLine($"Membership {membershipList[index].MembershipID} has been deleted.");
                                membershipList.RemoveAt(index);
                                membershipFound = true;
                            }
                        }
                        if (membershipFound != true)
                        {
                            Console.WriteLine("Account not found");
                            Console.WriteLine("Would you like to search again? (Y/N)");
                            string ?searchAgain = Console.ReadLine();
                            if (searchAgain == "N" || searchAgain == "n")
                            {
                                Console.WriteLine("Search canceled. Returning to main menu.");
                                break; // break out of the search loop
                            }
                        }
                    } while (!membershipFound);
                } // end D

                /* L - List all of the memberships in the list including all of the information for each account type.
                same as R */
                if (mainMenuChoice == "L" || mainMenuChoice == "l")
                {
                    Console.WriteLine("You selected L - List all of the memberships in the list including all of the information for each account type.");
                    foreach (MembershipGeneric membershipDetails in membershipList)
                    {
                        Console.WriteLine(membershipDetails);
                    }    
                }  //end R

                /* P - Perform a purchase transaction by getting a membership number from the user and a purchase amount
                and if the membership exists add the purchase amount to the monthly purchase total. */
                if (mainMenuChoice == "P" || mainMenuChoice == "p")
                {
                    Console.WriteLine("You selected P - Perform a purchase transaction by getting a membership number from the user and a purchase amount and if the membership exists add the purchase amount to the monthly purchase total.");
                    bool membershipFound = false;
                    do
                    {
                        Console.WriteLine("Enter the membership ID");
                        int searchMembershipID = Convert.ToInt32(Console.ReadLine());
                        //loop through membershipList to search for memberShipId
                        for (int index = 0; index < membershipList.Count; index++)
                        {
                            if (membershipList[index].MembershipID == searchMembershipID)
                            //if membership is found, call GetPositiveInt (from the program class), and then pass to the appropriate purchase method 
                            {
                                membershipList[index].Purchase(GetPositiveInt(0, "purchase"));
                                membershipFound = true;
                            }
                        }
                        if (membershipFound != true)
                        {
                            Console.WriteLine("Account not found");
                            Console.WriteLine("Would you like to search again? (Y/N)");
                            string searchAgain = Console.ReadLine();
                            //anything other than 'N' will stay in the search loop
                            if (searchAgain == "N" || searchAgain == "n")
                            {
                                Console.WriteLine("Search canceled. Returning to main menu.");
                                break; // break out of the search loop
                            }
                        }
                    } while (!membershipFound);
                } //end P

                /* T - Perform a return transaction by getting an membership number from the user and a return amount 
                and if the membership exists, perform the return by subtracting the return amount for the monthly purchase total. */
                if (mainMenuChoice == "T" || mainMenuChoice == "t")
                {
                    Console.WriteLine("You selected T - Perform a return transaction by getting an membership number from the user and a return amount and if the membership exists, perform the return by subtracting the return amount for the monthly purchase total.");
                    bool membershipFound = false;
                    do
                    {
                        Console.WriteLine("Enter the membership ID");
                        int searchMembershipID = Convert.ToInt32(Console.ReadLine());
                        //loop through membershipList to search for memberShipId
                        for (int index = 0; index < membershipList.Count; index++)
                        {
                            if (membershipList[index].MembershipID == searchMembershipID)
                            //if membership is found, call GetPositiveInt (from the program class), and then pass to the appropriate return method 
                            {
                                membershipList[index].Return(GetPositiveInt(0, "return"));
                                membershipFound = true;
                            }
                        }
                        if (membershipFound != true)
                        {
                            Console.WriteLine("Account not found");
                            Console.WriteLine("Would you like to search again? (Y/N)");
                            string searchAgain = Console.ReadLine();
                            //anything other than 'N' will stay in the search loop
                            if (searchAgain == "N" || searchAgain == "n")
                            {
                                Console.WriteLine("Search canceled. Returning to main menu.");
                                break; // break out of the search loop
                            }
                        }
                    } while (!membershipFound);
                } //end T

                /* A - Apply cash-back rewards as described above by getting a membership number from the user. */
                if (mainMenuChoice == "A" || mainMenuChoice == "a")
                {
                    Console.WriteLine("You selected A - Apply cash-back rewards as described above by getting a membership number from the user.");
                    bool membershipFound = false;
                    do
                    {
                        Console.WriteLine("Enter the membership ID");
                        int searchMembershipID = Convert.ToInt32(Console.ReadLine());
                        //loop through membershipList to search for memberShipId
                        for (int index = 0; index < membershipList.Count; index++)
                        {
                            if (membershipList[index].MembershipID == searchMembershipID)
                            //if membership is found, call the appropriate cashback method 
                            {
                                membershipList[index].ApplyCashBack();
                                membershipFound = true;
                            }
                        }
                        if (membershipFound != true)
                        {
                            Console.WriteLine("Account not found");
                            Console.WriteLine("Would you like to search again? (Y/N)");
                            string searchAgain = Console.ReadLine();
                            //anything other than 'N' will stay in the search loop
                            if (searchAgain == "N" || searchAgain == "n")
                            {
                                Console.WriteLine("Search canceled. Returning to main menu.");
                                break; // break out of the search loop
                            }
                        }
                    } while (!membershipFound);
                } //end A

                else if (mainMenuChoice == "Q" || mainMenuChoice == "q")
                {
                    Console.WriteLine("You selected Q - Quit the transaction processing.");
                    Console.WriteLine("Goodbye.");
                } //end Q

            }while (!(mainMenuChoice == "Q" || mainMenuChoice == "q")); //end main loop

        } //end Main emthod
    }  //end Program class
}  // end NameSpace