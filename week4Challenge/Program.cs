using System;
using System.Collections.Generic;

namespace Week4Challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      //test contructors 
      
      CdAccount testCdAccount1 = new CdAccount(111, "Cd", 100, .01);
      //Console.WriteLine(testCdAccount1);

      CheckingAccount testCheckingAccount1 = new CheckingAccount(222, "Checking", 200);
      //Console.WriteLine(testCheckingAccount1);

      SavingsAccount testSavingsAccount1 = new SavingsAccount(333, "Savings", 300);
      //Console.WriteLine(testSavingsAccount1);

      //test deposit
      //testAccount3.Deposit(100);
      //Console.WriteLine(testAccount3);

      //test savings withdrawl (aka default withdrawl behavior)
      //testSavingsAccount1.Withdrawl(100);

      //test checking withdrawl
      //testCheckingAccount1.Withdrawl(99);
      //testCheckingAccount1.Withdrawl(101);


      //test Cd withdrawl
      //testCdAccount1.Withdrawl(99);

            /* //create dictionary to hold account info
            Dictionary<int, Account> accountsDictionary = new Dictionary<int, Account>();

            accountsDictionary.Add(100, testCdAccount1);
            accountsDictionary.Add(200, testCheckingAccount1);
            accountsDictionary.Add(300, testSavingsAccount1);

            foreach(KeyValuePair<int, Account> accountDetails in accountsDictionary)
            {
              Console.WriteLine("{0} and {1}", accountsDictionary.Key, accountsDictionary);
              Console.WriteLine(accountsDictionary.Values);
            } */

      List<Account> accountList = new List<Account>();
      accountList.Add(testCdAccount1);
      accountList.Add(testCheckingAccount1);
      accountList.Add(testSavingsAccount1);

      // test looping through list to display options
      /* foreach (Account accountDetails in accountList)
      {
        Console.WriteLine(accountDetails);
      } */

      bool validUserChoice;
      char userChoice;
      
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
          userChoice = Convert.ToChar(Console.ReadLine());
          //verify user entry is valid
          validUserChoice = (userChoice == 'L' || userChoice == 'l' || userChoice == 'D' || userChoice == 'd' || userChoice == 'W' || userChoice == 'w' || userChoice == 'Q' || userChoice == 'q');
          
          if (!validUserChoice) //if not valid tell to enter valid option
          {
            Console.WriteLine("Please enter a valid option.");
          }
        } while (!validUserChoice); //end valid option loop
      
      //if L
      if (userChoice == 'L'|| userChoice == 'l')
      {
        Console.WriteLine("In the L area.");
      }

      //else if D
      if (userChoice == 'D' || userChoice == 'd')
      {
        Console.WriteLine("In the D area.");
      }

      //esle if W
      if (userChoice == 'W' || userChoice == 'w')
      {
        Console.WriteLine("In the W area.");
      }

      //else if Q
      if (userChoice == 'Q' || userChoice == 'q')
      {
        Console.WriteLine("Goodbye.");
      }

      } while (!(userChoice == 'Q' || userChoice == 'q')); //end main loop
    } //end main
  } //end Program class
} // end namespace