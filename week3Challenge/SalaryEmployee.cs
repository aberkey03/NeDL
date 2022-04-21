 
using System;

namespace EmployeeBonuses
{
    class SalaryEmployee : Employee
    {
        //SalaryEmployee properties 
        public int Salary
        {get;set;}

        //METHODS
        
        //HourlyEmployee Bonus method
        public override double BonusCalculation() 
        {
            return Salary*.1;  //10% of annual salary 
        }

        //HourlyEmployee ToString
        public override string ToString()
        {
            return $"Employee Name: {LastName}, {FirstName}; Employee Type: {EmployeeType}; Salary: {Salary}; Bonus: {BonusCalculation()} ";
        }

        //CONSTRUCTORS
        //empty HourlyEmployee constructor 
        public SalaryEmployee() :base()
        {
            Salary = -1;
        }

        //'standard' HourlyEmployee constuctor
        public SalaryEmployee (string newLastName, string newFirstName, char newEmployeeType, int newSalary) :base(newLastName, newFirstName, newEmployeeType)
        {
            Salary = newSalary;
        }   
    }
}