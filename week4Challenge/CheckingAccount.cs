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
        public override string ToString() //Account.ToString + CheckingAccount.AnnualFee
        {
            return base.ToString() + $" || Annual Fee: {AnnualFee}";
        }
    }
}