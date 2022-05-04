using System;

namespace HelloWorld
{
  class Program
  {
    
    static int Power(int baseVal, int expoVal)
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
      Console.WriteLine(Power(3, 2));    
    }
  }
}