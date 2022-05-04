using System;

namespace AngelsClassPractice
{
  class People
  {
    public string FirstName
    {get;set;}

    public string LastName
    {get;set;}

    public string PhoneNumber
    {get;set;}

    public string EmailAddress
    {get;set;}

    public People()
    {
        FirstName = null;
        LastName = null;
        PhoneNumber = null;
        EmailAddress = null;
    }

    public People(string newFirstName, string newLastName, string newPhoneNumber, string newEmailAddress)
    {
        FirstName = newFirstName;
        LastName = newLastName;
        PhoneNumber = newPhoneNumber;
        EmailAddress = newEmailAddress;
    }

    public string GetContactInfo()
    {
      return $"Phone Number: {PhoneNumber}, Email Address: {EmailAddress}";
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} | Phone Numer: {PhoneNumber}, Email Address: {EmailAddress}";
    }
  }
}