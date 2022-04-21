 
using System;

namespace EmployeeBonuses
{
    class HourlyEmployee : Employee
    {
        //HourlyEmployee properties 
        public double HourlyRate
        {get;set;}

        //METHODS
        //HourlyEmployee Bonus method
        public override double BonusCalculation() 
        {
            return HourlyRate*80;  //2 weeks compensation 
        }
        
        //CONSTRUCTORS
        //empty HourlyEmployee constructor 
        public HourlyEmployee() :base()
        {
            HourlyRate = -1.00;
        }

        //'standard' HourlyEmployee constuctor
        public HourlyEmployee (string newLastName, string newFirstName, char newEmployeeType, double newHourlyRate) :base(newLastName, newFirstName, newEmployeeType)
        {
            HourlyRate = newHourlyRate;
        }

        //HourlyEmployee ToString
        public override string ToString()
        {
            return $"Employee Name: {LastName}, {FirstName}; Employee Type: {EmployeeType}; Bonus: {BonusCalculation()} ";
        }

    }
}