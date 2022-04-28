using System;

namespace Week4Challenge
{
    class CdAccount : Account, ICaclulateInterest
    {
        //properties
        public double WithdrawlPenalty
            {get;set;}
        public double InterestRate
            {get;set;}
            =.02; //defualt interest rate for CD accounts

        //constructors
        public CdAccount(int newAccountId, string newAccountType, double newAccountBalance, double newWithdrawlPenalty) 
            : base(newAccountId, newAccountType, newAccountBalance)
        {
            WithdrawlPenalty = newWithdrawlPenalty;
        }
        
        //methods
        public double CalculateInterest() //implemented from ICalculateInterest
        {
            double accruedInterest = AccountBalance*InterestRate;
            return accruedInterest;
        }
        public override string ToString() //Account.ToString + CDAccount.WithdrwalPentalty + CDAccount.InterestRate + CDAccount.CalculateInterest()
        {
            return base.ToString() + $" || Early Withdrawl Penalty: {WithdrawlPenalty} || Interest Rate: {InterestRate} || Annual Interest Accrual: {CalculateInterest()}";
        }
        
    }
}