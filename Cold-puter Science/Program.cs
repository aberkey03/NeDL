using System;

namespace HelloWorld
{
  class Program
  {
    static bool NumNeg (int val1)
    {
        int val2;
        Console.WriteLine("Enter the temperature.");
        val2 = Convert.ToInt32(Console.ReadLine());
        return val1 > val2;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("How many temperatures do you have?");
      int numTemp = Convert.ToInt32(Console.ReadLine());
      int numNeg = 0;
      for (int i = 0; i < numTemp; i++)
      {
        if (NumNeg(0))
      {
        numNeg++;
      }
      else{};
      }   
      Console.WriteLine(numNeg);
    }
  }
}