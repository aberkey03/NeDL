using System;

namespace InterfaceList
{
  class SalaryEmployee : Employee, IBonus
  {
    double AnnualRate
        {get;set;}

    public double GetBonus() //why does this have to be public? 
    {
        return AnnualRate*.1;
    }
    
    public SalaryEmployee(int newEmployeeId, string newLastName, string newFirstName, char newEmployeeType, double newAnnualRate) : base(newEmployeeId, newLastName, newFirstName, newEmployeeType)
    {
        AnnualRate = newAnnualRate;
    }

    public override string ToString()
    {   
        return $"{base.ToString()}, AnnualRate: {AnnualRate}, Bonus: {GetBonus()}";
    }
  }
}