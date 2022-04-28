using System;

namespace Week4Challenge
{
    abstract class Account
    {
        //properties
        public int AccountId
            {get;set;}
        public string AccountType 
            {get;set;}
            = "Default AccountType value."; //default value so the string can never be null
        public double AccountBalance
            {get;set;}
        
        //constructors
        public Account(int newAccountId, string newAccountType, double newAccountBalance)
        {
            AccountId = newAccountId;
            AccountType = newAccountType;
            AccountBalance = newAccountBalance;
        }

        //methods

        //default Deposit behavior
        public void Deposit(double depositAmount)
        {
            double newAccountBalance = AccountBalance + depositAmount;
            AccountBalance = newAccountBalance;
        }
        //defualy Withdrawl behavior
        public virtual void Withdraw(double withdrwalAmount)
        {
            double newAccountBalance = AccountBalance - withdrwalAmount;
            AccountBalance = newAccountBalance;
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {    
            return $"Account ID: {AccountId}, Account Type: {AccountType} || Current Balance: ${AccountBalance}";
        }
        

    }
}