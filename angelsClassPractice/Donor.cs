using System;

namespace AngelsClassPractice
{
  class Donor : People
  {
    public int RegDonation
    {get;set;}
    public int TotalDonation
    {get;set;}
    public bool ContactOk
    {get;set;}
    public Donor():base()
    {
        //FirstName = null;
        //LastName = null;
        //PhoneNumber = null;
        //EmailAddress = null;
        RegDonation = -1;
        TotalDonation = -1;
        ContactOk = false;
    }

    public Donor(string newFirstName, string newLastName, string newPhoneNumber, string newEmailAddress, int newRegDontation, int newTotalDonation, bool newContactOk): base (newFirstName, newLastName, newPhoneNumber, newEmailAddress)
    {
        //FirstName = newFirstName;
        //LastName = newLastName;
        //PhoneNumber = newPhoneNumber;
        //EmailAddress = newEmailAddress;
        RegDonation = newRegDontation;
        TotalDonation = newTotalDonation;
        ContactOk = newContactOk;
    }

    public int TotalDonationMethod(int donation)
    {
        TotalDonation = TotalDonation+donation;
        return TotalDonation;
    }


    public override string ToString()
    {
        return $"{FirstName} {LastName} | Phone Numer: {PhoneNumber}, Email Address: {EmailAddress} | Regular Dontation: {RegDonation}, Total Donation: {TotalDonation}, Contact Ok?: {ContactOk}";
    }
  }
}