using System;

namespace Week4Challenge
{
    class CheckingAccount : Account
    {
        //properties
        public double AnnualFee
            {get;set;}
            =50;
        
        //constructors
        public CheckingAccount(int newAccountId, string newAccountType, double newAccountBalance, double newAnnualFee) 
            : base(newAccountId, newAccountType, newAccountBalance)
        {
            AnnualFee = newAnnualFee; //assign non-standard AnnualFee
        }
        public CheckingAccount(int newAccountId, string newAccountType, double newAccountBalance) 
            : base(newAccountId, newAccountType, newAccountBalance)
        {
            //pull standard assigned value 50
        }
        
        //methods
        public override void Withdraw(double withdrwalAmount) //overriden from Account class
        {
            if (withdrwalAmount < AccountBalance * .5)
            {
                double newAccountBalance = AccountBalance - withdrwalAmount;
                AccountBalance = newAccountBalance;
                Console.WriteLine(ToString());
            }
            else 
            {
                Console.WriteLine("Nonsuficient funds.");
                Console.WriteLine(ToString());
            }
        }
        
        public override string ToString() //Account.ToString + CheckingAccount.AnnualFee
        {
            return base.ToString() + $" || Annual Fee: {AnnualFee}";
        }
    }
}