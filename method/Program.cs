using System;

namespace MyApplication
{
  class Program
  {
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
      int minScoreValue = -1;
      int maxScoreValue = 101;
      int totalScore = 0;
      for (int s = 0; s < 4; s++)
      {
          //get hw score, validate within 0-100
          int score = GetValueInRange(minScoreValue,maxScoreValue,"score");
          //total starts at 0, and then each score is added through the loop
          totalScore = totalScore + score;
          Console.WriteLine(totalScore);
      }
    }  
  }
}