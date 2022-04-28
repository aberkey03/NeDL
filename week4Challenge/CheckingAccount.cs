using System;

namespace Week4Challenge
{
    class CheckingAccount : Account
    {
        //properties
        public double AnnualFee
            {get;set;}
        
        //constructors
        public CheckingAccount(int newAccountId, string newAccountType, double newAccountBalance, double newAnnualfee) 
            : base(newAccountId, newAccountType, newAccountBalance)
        {
            AnnualFee = newAnnualfee;
        }
        
        //methods
        public override void Withdrawl(double withdrwalAmount) //overriden from Account class
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