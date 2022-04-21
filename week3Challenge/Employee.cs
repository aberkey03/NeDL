 
using System;

namespace EmployeeBonuses
{
    class Employee //base class
    {
        //base Properties
        public string LastName
        {get;set;}
        public string FirstName
        {get;set;}
        public char EmployeeType
        {get;set;}
        public double Bonus
        {get;set;}

        //base field (only used by base class)
        private double compensation;

        //base Bonus method
        public double BonusCalculation(char employeeType, double compensation) //set to return double so can be polymorphed by subclasses
        {
            return 0.0; //for Employee class bonus will always be 0 
        }
        
        //CONSTRUCTORS

        //empty base contructor
        public Employee()
        {
            LastName = "";
            FirstName = "";
            EmployeeType = 'U'; //U = undefined
            compensation = -1.0;
        }
        
        //'standard' base constuctor
        public Employee(string newLastName, string newFirstName, char newEmployeeType)
        {
            LastName = newLastName;
            FirstName = newFirstName;
            EmployeeType = newEmployeeType;
            compensation = 0.0;
        }

        //base ToString
        public override string ToString()
        {
            return $"Employee Name: {LastName}, {FirstName}; Employee Type: {EmployeeType}; Bonus: {BonusCalculation(EmployeeType, compensation)} ";
        }

    }
}