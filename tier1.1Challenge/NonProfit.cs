using System;

namespace CustomerMemberships
{
    class NonProfit : MembershipGeneric
    {
        // PROPORTIES 
        public bool MilitaryEducation // indicates whether the non-profit is a qualifying military or education non-profit
        {get; set;}

        // CONSTRUCTOR(S)
        public NonProfit(int newMembershipID, string newPrimaryEmailAddress, string newMembershipType, bool newMilitaryEducation ,double newAnnualCost, double newPuchasesMonthly) : base (newMembershipID, newPrimaryEmailAddress, newMembershipType, newAnnualCost, newPuchasesMonthly)
        {
            MilitaryEducation = newMilitaryEducation;
        }
        // METHODS
        // toString
        public override string ToString()
        {
            return $"{base.ToString()} || Is military or non-profit? {MilitaryEducation}"; 
        }

        // ApplyCashBack() overiridden from MembershipGeneric
        // if MilitaryEducation is false, purchases * cashBackPercentage 
        // if MilitaryEducation is true, purchases * cashBackPercentage, * 2
        // display cash back, clear monthly purchases, display account overview 
        public override void ApplyCashBack()
        {
            double cashBackPercentage = .01;
            double cashBackAmt;
            if (MilitaryEducation)
            {
                cashBackAmt = PuchasesMonthly * cashBackPercentage;
            }
            else
            {
                cashBackAmt = PuchasesMonthly * cashBackPercentage;
                cashBackAmt = cashBackAmt * 2;
            }
            Console.WriteLine($"Cash-back reward request for Membership ID {MembershipID} in the amount of ${cashBackAmt} has been made.");
            PuchasesMonthly = 0;
            Console.WriteLine(ToString());
        }
    }
}