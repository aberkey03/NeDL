using System;

namespace CustomerMemberships
{
    class Executive : MembershipGeneric, ISpecialOffer
    {
        // PROPERTIES
            // ONLY USES BASE CLASS PROPERTIES

        // CONTRUCTOR(S)
        public Executive(int newMembershipID, string newPrimaryEmailAddress, string newMembershipType, double newAnnualCost, double newPuchasesMonthly) : base (newMembershipID, newPrimaryEmailAddress, newMembershipType, newAnnualCost, newPuchasesMonthly)
        {
            // ONLY USES BASE CLASS PROPERTIES/CONTRUCTOR
        }

        // METHODS
        public override string ToString()
        {
            return $"{base.ToString()} || Special Offer: ${SpecialOffer()}"; 
        }
        
        // SpecialOffer() implemented from ISpecialOffer
        // returns 50% of the annual membership cost
        public double SpecialOffer()
        {
            double specialOfferDiscount = .50;
            double specialOfferAmt = AnnualCost * specialOfferDiscount;
            return specialOfferAmt;
        }
        
        // ApplyCashBack() overiridden from MembershipGeneric
        // if balance < $1000, use cashBackPercentage1
        // if balance > $1000, use cashBackPercentage2
        // display cash back, clear monthly purchases, display account overview 
        public override void ApplyCashBack()
        {
            double cashBackPercentage1 = .02;
            double cashBackPercentage2 = .03;
            double cashBackAmt;
            if (PuchasesMonthly < 1000)
            {
                cashBackAmt = PuchasesMonthly * cashBackPercentage1;
            }
            else
            {
                cashBackAmt = PuchasesMonthly * cashBackPercentage2;
            }
            Console.WriteLine($"Cash-back reward request for Membership ID {MembershipID} in the amount of ${cashBackAmt} has been made.");
            PuchasesMonthly = 0;
            Console.WriteLine(ToString());
        }
    }
}