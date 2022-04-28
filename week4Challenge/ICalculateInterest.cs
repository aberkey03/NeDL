using System;

namespace Week4Challenge
{
  interface ICaclulateInterest
  {
    //properties
    public double InterestRate
      {get;set;}
     
    //constructors
      //no constructors for Interface 

    //methods
    public double CalculateInterest();

  }
}