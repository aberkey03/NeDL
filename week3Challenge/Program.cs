 
using System;

namespace EmployeeBonuses
{
    class Program
    {
        static void Main (string[] args)
        {
           //test individual class constructors and ToStrings

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
            HourlyEmployee testHourlyEmployee2 = new HourlyEmployee("Employee", "Hourly", 'H', 25.00);
            Console.WriteLine(testHourlyEmployee2);

            //test empty SalaryEmployee Constructor
            SalaryEmployee testSalaryEmployee1 = new SalaryEmployee();
            Console.WriteLine(testSalaryEmployee1);

            //test 'standard' SalaryEmployee Constructor
            SalaryEmployee testSalaryEmployee2 = new SalaryEmployee("Employee", "Salary", 'S', 80000);
            Console.WriteLine(testSalaryEmployee2);
            
            //write blank line to seperate testing
            Console.WriteLine("");

            // initialize array of Employees
            Employee [] employeeArray = new Employee [20];
            
            employeeArray[0] = testEmployee2;
            employeeArray[1] = testHourlyEmployee2;
            employeeArray[3] = testSalaryEmployee2;

            //loop through array and print only those with data
            //reuse for R
            for (int i = 0; i < employeeArray.Length; i++)
            {
                if(!(employeeArray[i]==null))
                {
                    Console.WriteLine(employeeArray[i]);
                }
            }
            


        }

    }
}