using System;

namespace InterfaceList
{
  class HourlyEmployee : Employee, IBonus
  {
    double HourlyRate
        {get;set;}

    public double GetBonus() //why does this have to be public? 
    {
        return HourlyRate*80;
    }
    
    public HourlyEmployee(int newEmployeeId, string newLastName, string newFirstName, char newEmployeeType, double newHourlyRate) : base(newEmployeeId, newLastName, newFirstName, newEmployeeType)
    {
        HourlyRate = newHourlyRate;
    }

    public override string ToString()
    {   
        return $"{base.ToString()}, HourlyRate: {HourlyRate}, Bonus: {GetBonus()}";
    }
  }
}