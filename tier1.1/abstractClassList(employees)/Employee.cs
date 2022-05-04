using System;

namespace AbstractEmployee
{
  abstract class Employee : People
  {
    public string LastName
    {get;set;}
    public string FirstName
    {get;set;}
    public string EmployeeType
    {get;set;}

    public Employee():base()
    {
        LastName = "";
        FirstName = "";
        EmployeeType = "";
    }
    public Employee(string newEyeColor, string newLastName, string newFirstName, string newEmployeeType):base(newEyeColor)
    {
        LastName = newLastName;
        FirstName = newFirstName;
        EmployeeType = newEmployeeType;
    }

    public override string ToString()
    {
        return base.ToString() + ", Last Name: "+ LastName + ", First Name: "+ FirstName +" , Employee Type: " + EmployeeType;
    }
    public abstract double GetBonus();
    
  }
}