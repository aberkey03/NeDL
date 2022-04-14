using System;

namespace HelloWorld
{
  class Program
  {
    
    static int MyMin(int num1, int num2)
    {
      if (num1 < num2)
      {
        return num1;
      }
      else 
      {
        return num2;
      }
    }

    static int MyMax(int num1, int num2)
    {
      if (num1 > num2)
      {
        return num1;
      }
      else
      {
        return num2;
      }
    }

    static int GetValidInt(int maxVal, int minVal)
    {
      int val1;
      do
      {
        Console.WriteLine("Enter a valid integer between " + minVal + " and " + maxVal + "."); //prompt
        val1 = Convert.ToInt32(Console.ReadLine()); //get value
      }
      while //val1 is invalid
        (val1 < minVal || val1 > maxVal);
        
        return val1; //if val1 is valid
    }
    
    static void Main(string[] args)
    {
      //prompt for numQuiz
      //Console.WriteLine("How many quizes do you have?"); 
      //validate numQuiz is postive
      //int totQuiz = Int32.Parse(Console.ReadLine());
      //while (totQuiz < 0){
        //Console.WriteLine("Number of quizzes must be a positve number.");
        //Console.WriteLine("How many quizes do you have?");
        //totQuiz = Int32.Parse(Console.ReadLine());
      //}
      
    //initialize variables outside loop
    int maxScore = 0;
    int minScore = 101;
    int quizScore = 0;
    int totalScore = 0;

    int totQuiz = GetValidInt(101,0);

    
    for (int numQuiz = 1; numQuiz <= totQuiz; numQuiz++)
    {
      quizScore = GetValidInt(101,-1);
      //Console.WriteLine("Enter quiz score # " + numQuiz);
      //quizScore = Int32.Parse(Console.ReadLine());
      
      //input validation
      //while (quizScore < 0)
        //{
          //Console.WriteLine("Quiz score must be a positve number.");
          //Console.WriteLine("Enter quiz score # " + numQuiz);
          //quizScore = Int32.Parse(Console.ReadLine());
        //}
      
      //max
      maxScore = MyMax(maxScore,quizScore);
      //min
      minScore = MyMin(minScore,quizScore);

      
      //add to total scores
      totalScore = totalScore + quizScore;
    }
    

    //outputs
    Console.WriteLine("Min: " + minScore);
    Console.WriteLine("Max: " + maxScore);
    Console.WriteLine("Avg: " + (totalScore / totQuiz));
    }
  }
}