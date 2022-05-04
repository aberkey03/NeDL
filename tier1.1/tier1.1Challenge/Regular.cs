using System;

namespace CustomerMemberships
{
    class Regular : MembershipGeneric, ISpecialOffer
    {
        // PROPERTIES
            // ONLY USES BASE CLASS PROPERTIES 

        // CONTRUCTOR(S)
        public Regular(int newMembershipID, string newPrimaryEmailAddress, string newMembershipType, double newAnnualCost, double newPuchasesMonthly) : base (newMembershipID, newPrimaryEmailAddress, newMembershipType, newAnnualCost, newPuchasesMonthly)
        {
            // ONLY USES BASE CLASS PROPERTIES/CONTRUCTOR
        }

        // METHODS
        public override string ToString()
        {
            return $"{base.ToString()} || Special Offer: ${SpecialOffer()}"; 
        }
        
        // SpecialOffer() implemented from ISpecialOffer
        // returns 25% of the annual membership cost
        public double SpecialOffer()
        {
            double specialOfferDiscount = .25;
            double specialOfferAmt = AnnualCost * specialOfferDiscount;
            return specialOfferAmt;
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