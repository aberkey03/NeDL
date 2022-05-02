using System;

namespace CustomerMemberships
{
  abstract class MembershipGeneric
  {
    // PROPERTIES
    public int MembershipID
      {get;set;}
    public string PrimaryEmailAddress
      {get;set;}
    public string MembershipType
      {get;set;}
    public double AnnualCost
      {get;set;}
    public double PuchasesMonthly
      {get;set;}
    
    // CONSTRUCTOR(S)
    public MembershipGeneric(int newMembershipID, string newPrimaryEmailAddress, string newMembershipType, double newAnnualCost, double newPuchasesMonthly)
    {
      MembershipID = newMembershipID;
      PrimaryEmailAddress = newPrimaryEmailAddress;
      MembershipType = newMembershipType;
      AnnualCost = newAnnualCost;
      PuchasesMonthly = newPuchasesMonthly;
    }

    // METHODS

    // TODO toString()
    public override string ToString()
    {
      return $"Membership ID: {MembershipID} || Primary Email Address: {PrimaryEmailAddress} || Membership Type: {MembershipType} || Annual Cost: ${AnnualCost} || Monthly Puchase Total: ${PuchasesMonthly}"; 
    }

    // Purchase() 
    // add purchaseAmt to PuchasesMonthly 
    public void Purchase(double purchaseAmt)
    {
      PuchasesMonthly = PuchasesMonthly + purchaseAmt;
    }

    // Return()
    // subtract returnAmt from PuchasesMonthly 
    public void Return(double returnAmt)
    {
      PuchasesMonthly = PuchasesMonthly - returnAmt;
    }

    // abstract ApplyCashBack()
    public abstract void ApplyCashBack();
      // calculate cashback based on implementing class
      // display "Cash-back reward request for membership xxxxxx in the amount of $yyyy has been made."
      // clear PuchasesMonthly

      public int Search(List<MembershipGeneric> membershipList)
        {
            bool membershipFound = false;
            int result = -1;
            do
            {
                Console.WriteLine("Enter the membership ID");
                int searchMembershipID = Convert.ToInt32(Console.ReadLine());
                for (int index = 0; index < membershipList.Count; index++)
                {
                    if (membershipList[index].MembershipID == searchMembershipID)
                    {
                        Console.WriteLine("Membership found.");
                        Console.WriteLine(membershipList[index]);
                        membershipFound = true;
                        result = membershipList[index].MembershipID;
                    }
                }
                if (membershipFound != true)
                {
                    Console.WriteLine("Account not found");
                    Console.WriteLine("Would you like to search again? (Y/N)");
                    char searchAgain = Convert.ToChar(Console.ReadLine());
                    if (searchAgain == 'N')
                    {
                        Console.WriteLine("Search canceled. Returning to main menu.");
                        membershipFound = true; // should break out of the search loop
                    } 
                }
            } while (!membershipFound);
            return result;
        }
  }
}