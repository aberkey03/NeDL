using System;

namespace HelloWorld
{
  class Program
  { 
    static int GetPositiveInt (int minVal, string variableName) 
    //minVal = minimum value
    //if valid, return val1 
    //if invalid prompt for another entry
    {
      int val; //var for user entry
      do
      {
        Console.WriteLine("Enter " + variableName + "." + " " + variableName + " must be greater than " + minVal + ".");
        val = Convert.ToInt32(Console.ReadLine());
      }
      //repeat while less than min
      while (val < minVal);
      return val;
    }
    static int GetValueInRange (int minVal1, int maxVal1, string variableName1) 
    //MinVal1 = minimum value
    //MaxVal1 = maxium value
    //variableName = name of value to check
    //if valid, return val1 
    //if invalid prompt for another entry
    {
      int val1; 
      do
      {
        Console.WriteLine("Enter " + variableName1 + "." + " " + variableName1 + " must be greater than " + minVal1 + " and less than " + maxVal1 +"." );
        val1 = Convert.ToInt32(Console.ReadLine());
      }
      //repeat while less than min, or more than max
      while (val1 < minVal1 || val1 >maxVal1);
      return val1;
    }

    static void Main(string[] args)
    {
      int minVal = -1;
      int maxVal = 101;

      Console.WriteLine(GetPositiveInt(minVal,"number of students"));
    }
  }
}