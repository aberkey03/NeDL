using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number of quizes."); //prompt for number of quizzes
      int quizTotalNumber = Int32.Parse(Console.ReadLine());
      while (quizTotalNumber<0) //user entry validation
      {
        Console.WriteLine("Number of quizzes must be a positve number.");
        Console.WriteLine("Enter the number of quizes.");
        quizTotalNumber = Int32.Parse(Console.ReadLine()); 
      }
      int maxScore = -1;
      int minScore = 101;
      int quizScore = 0;
      int totalQuizScores = 0;
      int quizAvg = 0;

      for (int baseQuiz = 1; baseQuiz <= quizTotalNumber; baseQuiz++)  //this is adding 2 instead of 1?
      {
        Console.WriteLine("Enter quizz score " + baseQuiz);
        quizScore = Int32.Parse(Console.ReadLine());
          
          while (quizTotalNumber<0) //user entry validation
        {
          Console.WriteLine("Number of quizzes must be a positve number.");
          Console.WriteLine("Enter the number of quizes.");
          quizTotalNumber = Int32.Parse(Console.ReadLine());
        }
   
          if (quizScore > maxScore) 
              {
                maxScore = quizScore;
              }

          if (quizScore < minScore)
              {
                minScore = quizScore;
              }
          //maxScore = Math.Max(maxScore, quizScore);
          //minScore = Math.Min(minScore, quizScore);

          
          totalQuizScores = totalQuizScores + quizScore;
           
      }
      quizAvg = totalQuizScores / quizTotalNumber;

      Console.WriteLine("Avg: " + quizAvg);
      Console.WriteLine("Max: " + maxScore);
      Console.WriteLine("Min: " + minScore);
    }
    
  }
  
}
      
      


    
  
