using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //prompt for Cel or Far  
      Console.WriteLine("Would you like to convert Celsius to Farenheit or Fahrenheit to Celcius?");
      //asign to tempUnit string
      string tempUnit = Console.ReadLine();

      //promp for degrees
      Console.WriteLine("Enter the temperature to convert from " + tempUnit);
      double degreesToConvert = Double.Parse(Console.ReadLine());

      //conver to cel
      if (tempUnit == "Celsius to Farenheit") {Console.WriteLine(degreesToConvert + " Celcius = " + ((degreesToConvert * (9.0 / 5.0)) + 32) + " Farenheit");
      }

      //convert to far
      else if (tempUnit == "Fahrenheit to Celcius") {Console.WriteLine(degreesToConvert + " Farenheit = " + (degreesToConvert - 32) * (5.0/9.0) + " Celcius");
      }
      //Console.WriteLine(tempUnit + " " + degreesToConvert);


    }
  }
}