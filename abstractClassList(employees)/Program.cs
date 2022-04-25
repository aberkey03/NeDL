using System;

namespace AbstractEmployee
{
  class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee testHourly = new HourlyEmployee("green", "Strange", "Stephen", "H", 17.77);
            //Console.WriteLine(testHourly);

            SalaryEmployee testSalary = new SalaryEmployee("blue", "Banner", "Bruce", "S", 55000);
            //Console.WriteLine(testSalary);
            
            List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();
            List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();

            hourlyEmployeeList.Add(testHourly);
            hourlyEmployeeList.Add(new HourlyEmployee());
            hourlyEmployeeList.Add(new HourlyEmployee("brown", "Rogers", "Steve", "H", 19.63));

            salaryEmployeeList.Add(testSalary);
            salaryEmployeeList.Add(new SalaryEmployee("blue", "Romanoff", "Natasha", "S", 77991));

            Console.WriteLine("Hourly Employees:");
            foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
            {
                Console.WriteLine(anEmployee);
            }

            Console.WriteLine("Salary Employees:");
            foreach (SalaryEmployee anEmployee in salaryEmployeeList)
            {
                Console.WriteLine(anEmployee);
            }
            
            hourlyEmployeeList.RemoveAt(1);

            List<HourlyEmployee> hourlyEmployeeList2 = new List<HourlyEmployee>(hourlyEmployeeList);
            hourlyEmployeeList2.AddRange(hourlyEmployeeList);
            Console.WriteLine("Hourly Employees2:");
            foreach (HourlyEmployee anEmployee in hourlyEmployeeList2)
            {
                Console.WriteLine(anEmployee);
            }
        }
    }
}