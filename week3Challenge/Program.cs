 
using System;

namespace EmployeeBonuses
{
    class Program
    {
        static void Main (string[] args)
        {
            //test empty Employee Constructor
            Employee testEmployee1 = new Employee();
            Console.WriteLine(testEmployee1);

            //test 'standard' Employee Constructor 
            Employee testEmployee2 = new Employee("Employee", "Test", 'E');
            Console.WriteLine(testEmployee2);
            
            //test empty HourlyEmployee Constructor
            HourlyEmployee testHourlyEmployee1 = new HourlyEmployee();
            Console.WriteLine(testHourlyEmployee1);

            //test 'standard' HourlyEmployee Constructor
            HourlyEmployee testHourlyEmployee2 = new HourlyEmployee("Employee", "Test", 'H', 25.00);
            Console.WriteLine(testHourlyEmployee2);

            //test empty SalaryEmployee Constructor

            //test 'standard' SalaryEmployee Constructor

        }

    }
}