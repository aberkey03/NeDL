using System;

namespace Week4Challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      //test contructors 
      
      CdAccount testAccount1 = new CdAccount(111, "Cd", 100, .01);
      //Console.WriteLine(testAccount1);

      CheckingAccount testAccount2 = new CheckingAccount(222, "Checking", 200, .02);
      //Console.WriteLine(testAccount2);

      SavingsAccount testAccount3 = new SavingsAccount(333, "Savings", 300);
      //Console.WriteLine(testAccount3);

      //test deposit
      //testAccount3.Deposit(100);
      //Console.WriteLine(testAccount3);

      


    }
  }
}