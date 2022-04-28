using System;

namespace Week4Challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      //test contructors 
      
      CdAccount testCdAccount1 = new CdAccount(111, "Cd", 100, .01);
      Console.WriteLine(testCdAccount1);

      CheckingAccount testCheckingAccount1 = new CheckingAccount(222, "Checking", 200, .02);
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

    }
  }
}