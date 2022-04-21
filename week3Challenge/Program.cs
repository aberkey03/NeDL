 
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
            
        }

    }
}