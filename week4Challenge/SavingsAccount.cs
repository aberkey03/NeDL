using System;

namespace Week4Challenge
{
    class SavingsAccount : Account, ICaclulateInterest
    {
        //properties
        public double InterestRate
            {get;set;}
            =.005; //defualt interest rate for savings accounts
        
        //constructors
        public SavingsAccount(int newAccountId, string newAccountType, double newAccountBalance) : base(newAccountId, newAccountType, newAccountBalance)
        {
            ; //no new properties to add
        }

        //methods
        public double CalculateInterest() //implemented from ICalculateInterest
        {
            double accruedInterest = AccountBalance*InterestRate;
            return accruedInterest;
        }
        public override string ToString() //Account.ToString + SavingsAccount.InterestRate + SavingsAccount.CalculateInterest() 
        {
            return base.ToString() + $" || Annual Interest Rate: {InterestRate}" + $" || Interest Accural: ${CalculateInterest()}";
        }
    }
}