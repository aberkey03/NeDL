using System;

namespace AngelsClassPractice
{
  class Program
  {
    static void Main(string[] args)
    {
      People noOne = new People(); 
      Console.WriteLine(noOne);

      People johnDoe = new People("John", "Doe", "(123)456-7890", "john.doe@people.com");
      Console.WriteLine(johnDoe);

      Patient NoOne = new Patient();
      Console.WriteLine(NoOne);

      Patient janeDoe = new Patient("Jane", "Doe", "(234)567-8901", "john.doe@patient.com", "BlueCross", "high");
      Console.WriteLine(janeDoe);

      Donor daddyWarbucks = new Donor();
      Console.WriteLine(daddyWarbucks);

      Donor DaddyWarbucks = new Donor("Daddy", "Warbucks", "(345)678-9012", "daddywarbucks@donor.com", 1000, 50000, true);
      Console.WriteLine(DaddyWarbucks);

      DaddyWarbucks.TotalDonation = DaddyWarbucks.TotalDonationMethod(DaddyWarbucks.RegDonation);
      Console.WriteLine(DaddyWarbucks);

      Console.WriteLine(DaddyWarbucks.GetContactInfo());

      //set BigDaddyWarbucks to DaddyWarbucks values, and add prefered donation 
      DonorIndividual BigDaddyWarbucks = new DonorIndividual(DaddyWarbucks.FirstName, DaddyWarbucks.LastName, DaddyWarbucks.PhoneNumber, DaddyWarbucks.EmailAddress, DaddyWarbucks.RegDonation, DaddyWarbucks.TotalDonation, DaddyWarbucks.ContactOk, "tax time" );
      Console.WriteLine(BigDaddyWarbucks);

      //update total donation via method from donor class
      BigDaddyWarbucks.TotalDonation = BigDaddyWarbucks.TotalDonationMethod(BigDaddyWarbucks.RegDonation);
      Console.WriteLine(BigDaddyWarbucks.TotalDonation);
    }
  }
}