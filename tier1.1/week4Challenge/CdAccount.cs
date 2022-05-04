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
        public CdAccount(int newAccountId, string newAccountType, double newAccountBalance, double newWithdrawlPenalty, double newInterestRate) 
            : base(newAccountId, newAccountType, newAccountBalance)
        {
            WithdrawlPenalty = newWithdrawlPenalty;
            InterestRate = newInterestRate;
        }
        
        //methods
        public override void Withdraw(double withdrwalAmount) //overriden from Account class
        {
            double totalWithdrwal = withdrwalAmount + (withdrwalAmount * WithdrawlPenalty);
            //Console.WriteLine(totalWithdrwal);
            if (totalWithdrwal < AccountBalance)
            {
                double newAccountBalance = AccountBalance - totalWithdrwal;
                AccountBalance = newAccountBalance;
                Console.WriteLine($"Early Withdrawl Penalty: {withdrwalAmount * WithdrawlPenalty}");
                Console.WriteLine($"Total transaction: {totalWithdrwal}");
                Console.WriteLine(ToString());
            }
            else 
            {
                Console.WriteLine("Nonsuficient funds.");
                Console.WriteLine(ToString());
            }
        }
        public double CalculateInterest() //implemented from ICalculateInterest
        {
            double accruedInterest = AccountBalance*InterestRate;
            return accruedInterest;
        }
        public override string ToString() //Account.ToString + CDAccount.WithdrwalPentalty + CDAccount.InterestRate + CDAccount.CalculateInterest()
        {
            return base.ToString() + $" || Early Withdrawl Penalty: {WithdrawlPenalty} || Interest Rate: {InterestRate} || Annual Interest Accrual: ${CalculateInterest()}";
        }
        
    }
}