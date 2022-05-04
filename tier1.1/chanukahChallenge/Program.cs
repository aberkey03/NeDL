using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int numCand = 0;
      Console.WriteLine("How many days are in your Chanuka Challenge?");
      int numDays = Int32.Parse(Console.ReadLine());
      for (int d = 0; d<numDays; d++)
      {
        Console.WriteLine(d);
        numCand = numCand + (d + 1);
      } 
      Console.WriteLine(numCand + numDays);  
    }
  }
}