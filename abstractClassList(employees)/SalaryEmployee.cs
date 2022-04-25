using System;

namespace AbstractEmployee
{
  class SalaryEmployee : Employee
  {
    public int AnnualRate
    {get;set;}

    public SalaryEmployee() : base()
    {
        AnnualRate = 0;
    }
    public SalaryEmployee(string newEyeColor, string newLastName, string newFirstName, string newEmployeeType, int newAnnualRate) : base (newEyeColor, newLastName, newFirstName, newEmployeeType)
    {
        AnnualRate = newAnnualRate;
    }

    public override double GetBonus()
    {
        return AnnualRate * .1;
    }

    public override string ToString()
    {
        return base.ToString() + " , Annual Rate: " + AnnualRate + ", Bonus: " + GetBonus();
    }
  }
}