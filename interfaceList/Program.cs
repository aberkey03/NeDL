using System;
using System.Collections.Generic;

namespace InterfaceList
{
  class Program
  {
    static void Main(string[] args)
    {
        int startingIndex = 1001;
        int newIndex;
        Dictionary<int, Employee> employeeDictionatry = new Dictionary<int, Employee>();

        employeeDictionatry.Add(startingIndex, new Employee(1001, "Berkey", "Andrew", 'S'));
        employeeDictionatry.Add(newIndex = startingIndex+1, new Employee(1002, "Alesi", "Danielle", 'H'));

        employeeDictionatry.Add(newIndex = newIndex+1, new HourlyEmployee(1003, "Mason", "Becky", 'H', 17.77));
        employeeDictionatry.Add(newIndex = newIndex+1, new HourlyEmployee(1004, "Mason", "Zach", 'H', 16.66));

        employeeDictionatry.Add(newIndex = newIndex+1, new SalaryEmployee (1005, "Clayton", "Libby", 'S', 55000));
        employeeDictionatry.Add(newIndex = newIndex+1, new SalaryEmployee (1006, "Clayton", "Chris", 'S', 33333));

        /* Console.WriteLine(employeeDictionatry[1003]);

        Console.Write("Enter the new Employee ID:");
        int newEmployeeId = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the new employee last Name:");
        string newLastName = Console.ReadLine();
        Console.Write("Enter the new employee first Name:");
        string newFirstName = Console.ReadLine();
        Console.Write("Enter the new employee type:");
        char newEmployeeType = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter the new employee hourly rate:");
        double newHourlyRate = Convert.ToDouble(Console.ReadLine());

        employeeDictionatry.Add(newEmployeeId, new HourlyEmployee(newEmployeeId, newLastName, newFirstName, newEmployeeType, newHourlyRate)); */

        foreach (KeyValuePair<int, Employee> employeeInfo in employeeDictionatry)
        {
            Console.WriteLine("{0} and {1}", employeeInfo.Key, employeeInfo.Value);
        }

        /* Console.Write("Enter the new Employee ID:");
        newEmployeeId = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter the new employee last Name:");
        newLastName = Console.ReadLine();
        Console.Write("Enter the new employee first Name:");
        newFirstName = Console.ReadLine();
        Console.Write("Enter the new employee type:");
        newEmployeeType = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter the new employee hourly rate:");
        newHourlyRate = Convert.ToDouble(Console.ReadLine());

        employeeDictionatry.Add(newEmployeeId, new HourlyEmployee(newEmployeeId, newLastName, newFirstName, newEmployeeType, newHourlyRate)); */

        //foreach (int count in valueColl)


        //for (int i = 0; i < )
    }
  }
}