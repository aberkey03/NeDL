using System;

namespace HelloWorld
{
  class Program
  {
    static int FindMin(int val, int minVal) //check val against min, if val is less > set val = 'new' minVal
    {
        if (val < minVal)
            {
            minVal = val;
            }
        return minVal;
    }
    static int FindMax(int val, int maxVal) //check val against max, if val is less > set val = 'new' maxVal
    {
        maxVal = val;
        if (val > maxVal)
            {
            maxVal = val;
            }
        return maxVal;
    }
    
    static int GetPositiveInt (int minVal, string variableName) 
    //minVal = minimum value
    //if valid, return val1 
    //if invalid prompt for another entry
    {
      int val; //var for user entry
      Console.WriteLine(variableName + " must be greater than " + minVal + ".");
      do
      {
        Console.WriteLine("Enter " + variableName + ".");
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
      Console.WriteLine(variableName1 + " must be greater than " + minVal1 + " and less than " + maxVal1 +"." );
      do
      {
        Console.WriteLine("Enter " + variableName1 + ".");
        val1 = Convert.ToInt32(Console.ReadLine());
      }
      //repeat while less than min, or more than max
      while (val1 < minVal1 || val1 >maxVal1);
      return val1;
    }

    static void Main(string[] args)
    {
      //prompt for numStudents
      int numStudents = GetPositiveInt(-1, "number of students");
      //prmpt for numScores
      int numScores = GetPositiveInt(-1,"number of scores");

      int minScore = 101;
      int maxScore = -1;
      int classTotal;
      int studentTotal = 0;
      double studentAvg = 0;

      //initalize array
      int[,] studentScores = new int [numStudents,numScores];
      //for students
      for (int column=0;column<numStudents;column++)
      {
        Console.WriteLine($"{studentAvg} = {studentTotal}/{numScores}");
          //Console.WriteLine($"student {column+1} avg " +studentAvg);
        //for scores
        for (int row=0;row<numScores;row++)
        {
          studentScores[column, row] = GetValueInRange(-1,101,$"student {column+1} score {row+1}");
          //set score equal to position row
          Console.WriteLine($"student {column+1} score {row+1}" + "= " + studentScores[column,row]);
          minScore = FindMin(studentScores[column, row], minScore);
          maxScore = FindMax(studentScores[column, row], maxScore);
          studentTotal = studentTotal + studentScores[column, row]; 
        }
      }
      Console.WriteLine("min " + minScore);
      Console.WriteLine("max " + maxScore);
    }
  }
}
