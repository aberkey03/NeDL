using System;

namespace AngelsClassPractice
{
  class Patient : People
  {
    public string InsuranceProvider
    {get;set;}
    public string Need
    {get;set;}
    public Patient():base()
    {
        //FirstName = null;
        //LastName = null;
        //PhoneNumber = null;
        //EmailAddress = null;
        InsuranceProvider = null;
        Need = null;
    }

    public Patient(string newFirstName, string newLastName, string newPhoneNumber, string newEmailAddress, string newInsuranceProvider, string newNeed): base (newFirstName, newLastName, newPhoneNumber, newEmailAddress)
    {
        //FirstName = newFirstName;
        //LastName = newLastName;
        //PhoneNumber = newPhoneNumber;
        //EmailAddress = newEmailAddress;
        InsuranceProvider = newInsuranceProvider;
        Need = newNeed;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} | Phone Numer: {PhoneNumber}, Email Address: {EmailAddress} | Insurance Provider: {InsuranceProvider}, Need: {Need}";
    }
  }
}