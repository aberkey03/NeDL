using System;

namespace AngelsClassPractice
{
  class DonorIndividual : Donor
  {
    public string PreferredGivingTime
    {get;set;}
    public DonorIndividual():base()
    {
        //FirstName = null;
        //LastName = null;
        //PhoneNumber = null;
        //EmailAddress = null;
        //RegDonation = -1;
        //TotalDonation = -1;
        //ContactOk = false;
        PreferredGivingTime = null;
    }

    public DonorIndividual(string newFirstName, string newLastName, string newPhoneNumber, string newEmailAddress, int newRegDontation, int newTotalDonation, bool newContactOk, string newPreferredGivingTime): base (newFirstName, newLastName, newPhoneNumber, newEmailAddress, newRegDontation, newTotalDonation, newContactOk)
    {
        //FirstName = newFirstName;
        //LastName = newLastName;
        //PhoneNumber = newPhoneNumber;
        //EmailAddress = newEmailAddress;
        //RegDonation = newRegDontation;
        //TotalDonation = newTotalDonation;
        //ContactOk = newContactOk;
        PreferredGivingTime = newPreferredGivingTime;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} | Phone Number: {PhoneNumber}, Email Address: {EmailAddress} | Regular Dontation: {RegDonation}, Total Donation: {TotalDonation}, Contact Ok?: {ContactOk}, Preferred Giving Time: {PreferredGivingTime}";
    }

  }
}