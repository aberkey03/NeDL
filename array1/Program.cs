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
    
    static void Main(string[] args)
    {
      //prompt for numStudents
      Console.WriteLine("Enter the number of students.");
      int numStudents = Convert.ToInt16(Console.ReadLine());
      //prompt for numScores
      Console.WriteLine("Enter the number of scores.");
      int numScores = Convert.ToInt16(Console.ReadLine());
      //initalize array. set number of rows to numScores, set number of columns to numStudents
      int[,] classScores = new int [numStudents,numScores];
      //initalize class variables outside all loops
      int classTotalAvg = 0;
      int classMin = 101;
      int classMax = -1;
      int classAvg = 0;
      for (int i = 0; i<numStudents; i++)
      {  
        //initialize per student min, max, total
        int studentMax = -1;
        int studentMin = 101;
        int studentTotal = 0;
               
        for (int j = 0; j<numScores; j++)
        {
          //prompt for score j
          Console.WriteLine($"Enter student {i+1} score {j+1}");
          //set position i equal to score entered
          classScores[i,j] = (Convert.ToInt16(Console.ReadLine()));
          Console.WriteLine($"{i} {j} " + classScores[i,j]); //writes position in array
          //find min, max, and total for avg
          studentMin = FindMin(classScores[i,j], studentMin);
          studentMax = FindMax(classScores[i,j], studentMax);
          studentTotal = studentTotal + classScores[i,j];        
        }
        classMax = FindMax(studentMax,classMax);
        classMin = FindMin(studentMin,classMin);
        Console.WriteLine($"Student {i+1}'s max score: " + studentMax);
        Console.WriteLine($"Student {i+1}'s min score: " + studentMin);
        int studentAvg = 0;
        studentAvg = studentTotal/numScores;
        Console.WriteLine($"Student {i+1}'s avg score: " + studentAvg);
        classTotalAvg = classTotalAvg+studentAvg;
      }
      classAvg = classTotalAvg/numStudents;
      Console.WriteLine ("class min: " + classMin);
      Console.WriteLine ("class max: " + classMax);
      //Console.WriteLine ("numScores: " + numScores);
      Console.WriteLine ("avgScores: " + classAvg);
    }
  }
}