using System;

namespace CustomerMemberships
{
    class Program
    {
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
                    Console.WriteLine("In the 'C' area.");
                }

                /* DONE
                R - Read all of the memberships in the membership list.
                same as L */
                if (mainMenuChoice == "R" || mainMenuChoice == "r")
                {
                    Console.WriteLine("In the 'R' area.");
                    foreach (MembershipGeneric membershipDetails in membershipList)
                    {
                        Console.WriteLine(membershipDetails);
                    }
                }

                /* U - Update an existing membership based on membership ID. */
                if (mainMenuChoice == "U" || mainMenuChoice == "u")
                {
                    Console.WriteLine("In the 'U' area.");
                }

                /* D - Delete an existing membership based on membership ID. */
                if (mainMenuChoice == "D" || mainMenuChoice == "d")
                {
                    Console.WriteLine("In the 'D' area.");
                }

                /* DONE
                L - List all of the memberships in the list including all of the information for each account type.
                same as R */
                if (mainMenuChoice == "L" || mainMenuChoice == "l")
                {
                    Console.WriteLine("In the 'L' area.");
                    foreach (MembershipGeneric membershipDetails in membershipList)
                    {
                        Console.WriteLine(membershipDetails);
                    }    
                }

                /* P - Perform a purchase transaction by getting a membership number from the user and a purchase amount
                and if the membership exists add the purchase amount to the monthly purchase total. */
                if (mainMenuChoice == "P" || mainMenuChoice == "p")
                {
                    Console.WriteLine("In the 'P' area.");
                }

                /* T - Perform a return transaction by getting an membership number from the user and a return amount 
                and if the membership exists, perform the return by subtracting the return amount for the monthly purchase total. */
                if (mainMenuChoice == "T" || mainMenuChoice == "t")
                {
                    Console.WriteLine("In the 'T' area.");
                }

                /* A - Apply cash-back rewards as described above by getting a membership number from the user. */
                if (mainMenuChoice == "A" || mainMenuChoice == "a")
                {
                    Console.WriteLine("In the 'A' area.");
                }

            }while (!(mainMenuChoice == "Q" || mainMenuChoice == "q")); //end main loop
        } //end Main emthod
    }  //end Program class
}  // end NameSpace