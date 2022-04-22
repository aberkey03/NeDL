 
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

        /* //base field (only used by base class) >> ended up not needing this
        private double compensation; */

        //METHODS
        
        //base Bonus method
            //set to return double so can be polymorphed by subclasses
            //set to virtual so can be overridden by subclasses
        public virtual double BonusCalculation() 
        {
            return 0.0; //for Employee class bonus will always be 0 
        }
        //base GetSalary method
            //set to return double so can be polymorphed by subclasses
            //set to virtual so can be overridden by subclasses
        public virtual double GetSalary()
        {
            return -1;
        }
        //base GetHourlyRate
            //set to return double so can be polymorphed by subclasses
            //set to virtual so can be overridden by subclasses
        public virtual double GetHourlyRate()
        {
            return -1.00;
        }


        //base ToString
        public override string ToString()
        {
            return $"Employee Name: {LastName}, {FirstName}; Employee Type: {EmployeeType}; Bonus: {BonusCalculation()} ";
        }
        
        //CONSTRUCTORS

        //empty base contructor
        public Employee()
        {
            LastName = "";
            FirstName = "";
            EmployeeType = 'U'; //U = undefined
        }
        
        //'standard' base constuctor
        public Employee(string newLastName, string newFirstName, char newEmployeeType)
        {
            LastName = newLastName;
            FirstName = newFirstName;
            EmployeeType = newEmployeeType;
        }

        

    }
}