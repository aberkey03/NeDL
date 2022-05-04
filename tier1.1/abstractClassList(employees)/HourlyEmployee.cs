using System;

namespace AbstractEmployee
{
  class HourlyEmployee : Employee
  {
    public double HourlyRate
    {get;set;}

    public HourlyEmployee() : base()
    {
        HourlyRate = 0.0;
    }
    public HourlyEmployee(string newEyeColor, string newLastName, string newFirstName, string newEmployeeType, double newHourlyRate) : base (newEyeColor, newLastName, newFirstName, newEmployeeType)
    {
        HourlyRate = newHourlyRate;
    }

    public override double GetBonus()
    {
        return HourlyRate*80;
    }
    public override string ToString()
    {
        return base.ToString() + " , Hourly Rate: " + HourlyRate + ", Bonus: " + GetBonus();
    }
  }
}