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
            ; //uses default interest rate
        }
        public SavingsAccount(int newAccountId, string newAccountType, double newAccountBalance, double newInterestRate) : base(newAccountId, newAccountType, newAccountBalance)
        {
            InterestRate = newInterestRate; 
        }

        //methods
        public override void Withdraw(double withdrwalAmount)
        {
            double newAccountBalance = AccountBalance - withdrwalAmount;
            AccountBalance = newAccountBalance;
            Console.WriteLine(ToString());
        }
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