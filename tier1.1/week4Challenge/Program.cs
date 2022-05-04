using System;
using System.Text;
using System.Collections.Generic;

namespace Week4Challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      //create list to hold accounts 
      List<Account> accountList = new List<Account>();

      //create test accounts 
      
      accountList.Add(new CdAccount(111, "Cd", 100, .01)); //uses default interest
      accountList.Add(new CdAccount(112, "Cd", 11111.23, .05, .03)); //asignes new interest
    
      accountList.Add(new CheckingAccount(222, "Checking", 200, 25)); //asignes new annual fee
      accountList.Add(new CheckingAccount(223, "Checking", 55.22)); //uses default annual fee for CheckingAccount
      
      accountList.Add(new SavingsAccount(333, "Savings", 300));
      accountList.Add(new SavingsAccount(334, "Savings", 2315.83));
      

      bool validUserChoice;
      string userChoice;

      do //repeat main loop until Q is entered
      {
        do //repeat loop until a valid option is entered
        {
          validUserChoice = false; //set to false until a valid option is selected
          //display options
          Console.WriteLine("What do you want to do?");
          Console.WriteLine("L: List all of the accounts in the list.");
          Console.WriteLine("D: Perform a deposit transaction.");
          Console.WriteLine("W: Perform a withdrawal transaction.");
          Console.WriteLine("Q: Quit the program.");
          //read user entry
          userChoice = Console.ReadLine();
          //verify user entry is valid
          validUserChoice = (userChoice == "L" || userChoice == "l" || userChoice == "D" || userChoice == "d" || userChoice == "W" || userChoice == "w" || userChoice == "Q" || userChoice == "q");
          
          if (!validUserChoice) //if not valid tell to enter valid option
          {
            Console.WriteLine("Please enter a valid option.");
          }
        } while (!validUserChoice); //end valid option loop
      
      //if L >> List area
      if (userChoice == "L" || userChoice == "l")
      {
        Console.WriteLine("In the L area.");
        foreach (Account accountDetails in accountList)
        {
          Console.WriteLine(accountDetails);
        }
      }

      //else if D >> Deposit Area
      if (userChoice == "D" || userChoice == "d")
      {
        Console.WriteLine("In the D area.");
        bool accountFound = false;
        do //prompt for account until it is found
        {
          Console.WriteLine("Enter the account number for which you would like to make a deposit.");
          int userAccountSearch = Convert.ToInt16(Console.ReadLine());
          //loop through to find account
          //if found prompt for deposit
          //if not found advise user, and revert to main menu
          for (int index = 0; index < accountList.Count; index++)
          {
            if (accountList[index].AccountId == userAccountSearch) 
            {
              Console.WriteLine("Account found. How much would you like to deposit?");
              double depositAmount = Convert.ToInt32(Console.ReadLine());
              accountList[index].Deposit(depositAmount); //deposit method inherited from Account class
              Console.WriteLine(accountList[index]);
              accountFound = true;
            }
          }
          if (accountFound != true)
          {
            Console.WriteLine("Account not found");
          }
        } while (accountFound != true);
      }//end D area

      //else if W
      if (userChoice == "W" || userChoice ==  "w")
      {
        Console.WriteLine("In the W area.");
        bool accountFound = false;
        do //prompt for account until it is found
        {
          Console.WriteLine("Enter the account number from which you would like to withdraw.");
          int userAccountSearch = Convert.ToInt16(Console.ReadLine());
          //loop through to find account
          //if found, prompt for withdrawl
            //account must have sufficient funds 
          //if not found, prompt for account number again 
          for (int index = 0; index < accountList.Count; index++)
          {
            if (accountList[index].AccountId == userAccountSearch) 
            {
              Console.WriteLine($"Account found. How much would you like to withdraw?");
              double depositAmount = Convert.ToInt32(Console.ReadLine());
              accountList[index].Withdraw(depositAmount); //pulls default Account method for Savings, and CheckingAccount/CdAccount methods respectively
              accountFound = true;
            }
          }
          if (accountFound != true)
          {
            Console.WriteLine("Account not found");
          }
        } while (accountFound != true);
      }//end W area
      

      //else if Q
      if (userChoice == "Q" || userChoice == "q")
      {
        Console.WriteLine("Goodbye.");
      }

      } while (!(userChoice == "Q" || userChoice == "q")); //end main loop
    } //end main
  } //end Program class
} // end namespace