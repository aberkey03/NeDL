using System;

namespace InterfaceList
{
  class Employee
  {
    public int EmployeeId
        {get;set;}
    public string FirstName
        {get;set;}    
    public string LastName
        {get;set;}
    public char EmployeeType
        {get;set;}
    
    public Employee()
        {
            EmployeeId = -1;
            LastName = "";
            FirstName = "";
        }
    public Employee(int newEmployeeId, string newLastName, string newFirstName, char newEmployeeType)
    {
        EmployeeId = newEmployeeId;
        LastName = newLastName;
        FirstName = newFirstName;
        EmployeeType = newEmployeeType;
    }

    public override string ToString()
    {
        return $"Employee Id: {EmployeeId}, LastName: {LastName}, FirstName: {FirstName} || Type: {EmployeeType}";
    }
  }
} 
