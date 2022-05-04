using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number of feet.");
      int numFeet = Convert.ToInt32(Console.ReadLine());

      while (numFeet < 0)
        {
          Console.WriteLine("Number of feet must be a positive number.");
          Console.WriteLine("Enter the number of feet.");
          numFeet = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Inches: " + (numFeet * 12));
    }
  }
}