using System;
namespace HelloWorld
{
  class Program
  {
    
    static int GetPositiveInt (int minVal1, string variableName) 
    //prompt for valid number
    //determine if entry is < minVal1
    //if valid, return val1 
    //if invalid prompt for another entry
    {
      int val1; //var for user entry
      do
      {
        Console.WriteLine("Enter " + variableName + "." + " " + variableName + " must be greater than or equal to 1.");
        val1 = Convert.ToInt32(Console.ReadLine());
      }
      while (val1 < minVal1);
      return val1;
    }
    
    static int Power(int baseVal, int expoVal)
    //return = base to the power
    {
      int resultVal =1;  //start a 1    
      for (int x = 0; x < expoVal; x++)
      {
        resultVal = resultVal * baseVal; //resultVal = (1 * baseVal) repeated  expoVal times 
      } 
      return (resultVal);
    }
    static void Main(string[] args)
    {
      int baseVal;
      int expoVal;
      int resultVal;
      bool response;
      {
        do //prompt if the user wanted to calc an exponent, continues to calc until 'False' is entered 
        {
          Console.WriteLine("Do you want to calculate an exponent value? (Enter 'True' if Yes and 'False' if No.");
          response = Convert.ToBoolean(Console.ReadLine());
          //bool noResponse = Convert.ToBoolean("No");
          if (response == true)
          {
            baseVal = GetPositiveInt(1, "Base");
            Console.WriteLine("Base = " + baseVal);
            expoVal = GetPositiveInt(1, "Exponent");
            Console.WriteLine("Exponent = " + expoVal);
        
            resultVal = Power(baseVal, expoVal);
            Console.WriteLine(baseVal + "^" + expoVal + " = " + resultVal);
          }
          else 
          {
            Console.WriteLine("Ok. Have a great day.");
          }
        }
        while (response == true);  
      }
    }
  }
}

