using System;

namespace CustomerMemberships
{
    class Corporate : MembershipGeneric
    {
        // PROPERTIES
            // ONLY USES BASE CLASS PROPERTIES 

        // CONTRUCTOR(S)
        public Corporate(int newMembershipID, string newPrimaryEmailAddress, string newMembershipType, double newAnnualCost, double newPuchasesMonthly) : base (newMembershipID, newPrimaryEmailAddress, newMembershipType, newAnnualCost, newPuchasesMonthly)
        {
            // ONLY USES BASE CLASS PROPERTIES/CONTRUCTOR
        }

        // METHODS

        // toString()
        // no unique properties or info for Corperate memberships
        public override string ToString()
        {
            return $"{base.ToString()}"; 
        }
        
        // ApplyCashBack() overiridden from MembershipGeneric
        // flat cashBackPercentage 
        // display cash back, clear monthly purchases, display account overview 
        public override void ApplyCashBack()
        {
            double cashBackPercentage = .01;
            double cashBackAmt = PuchasesMonthly * cashBackPercentage;
            Console.WriteLine($"Cash-back reward request for Membership ID {MembershipID} in the amount of ${cashBackAmt} has been made.");
            PuchasesMonthly = 0;
            Console.WriteLine(ToString());
        }
    }
}