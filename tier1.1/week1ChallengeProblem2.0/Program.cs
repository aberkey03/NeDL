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
//?originally I had val < minval, but entering 0 would end the program? AHHHHH bc that wouldnt run the loooooooop!
      while (val <= minVal);
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
        Console.WriteLine("Enter " + variableName1 + ". " + variableName1 + " must be greater than " + minVal1 + " and less than " + maxVal1 +"." );
        val1 = Convert.ToInt32(Console.ReadLine());
      }
      //repeat while less than min, or more than max
      while (val1 < minVal1 || val1 > maxVal1);
      return val1;
    }
        static void Main(string[] args)
    {
      //set score range
      int minScoreValue = 0;
      int maxScoreValue = 100;
      
      // get number of students
      int numStudents = GetPositiveInt(0,"Number of students"); 
      
      //loop for number of students
      for (int s = 0; s < numStudents; s++) 
      {
        //get student name
        Console.WriteLine("Enter the students name."); //get student name 
        string studentName = Console.ReadLine(); 
        //initiate total score ints
        int totalHomeWorkScore = 0;
        int totalQuizScore = 0;
        int totalExamScore = 0;
        //get homework scores 5 times
        for (int h = 0; h < 5; h++)
        {
          //get hw score, validate within 0-100
          int homeWorkScore = GetValueInRange(minScoreValue,maxScoreValue,studentName + "'s home work score");
          //total starts at 0, and then each score is added through the loop
          totalHomeWorkScore = totalHomeWorkScore + homeWorkScore;
        }
        
        //get quiz scores 3 times
        for (int q = 0; q < 3; q++)
        {
            //get quiz score, validate within 0-100
            int quizScore = GetValueInRange(minScoreValue,maxScoreValue,studentName + "'s quiz score");
            //total starts at 0, and then each score is added through the loop
            totalQuizScore = totalQuizScore + quizScore;
        }
        
        //get exam scores 2 times
        for (int e = 0; e < 2; e++)
        {
          //get exam score, validate withing 0-100
          int examScore = GetValueInRange(minScoreValue,maxScoreValue,"'s exam score");
          //total starts at 0, and then each score is added through the loop
          totalExamScore = totalExamScore + examScore;
        }
        
        //avg collected scores
        int homeWorkAvg = totalHomeWorkScore/5;
        int quizAvg = totalQuizScore/3;
        int examAvg = totalExamScore/2;
        
        //output avgs
        Console.WriteLine(studentName + "'s HomeWork Avg: " + homeWorkAvg + "%");
        Console.WriteLine(studentName + "'s Quiz Avg: " + quizAvg + "%");
        Console.WriteLine(studentName + "'s Exam Avg: " + examAvg + "%");
        
        //calc weighted avgs
        double weightedHomeWork = homeWorkAvg*.5;
        double weightedQuiz = quizAvg*.3;
        double weightedExam = examAvg*.2;
        
        //output weighted avgs
        Console.WriteLine(studentName + "'s WEIGHTED HomeWork Avg: " + weightedHomeWork + "%");
        Console.WriteLine(studentName + "'s WEIGHTED Quiz Avg: " + weightedQuiz + "%");
        Console.WriteLine(studentName + "'s WEIGHTED Exam Avg: " + weightedExam + "%");
        
        //calc total score
        double totalWeighted = weightedHomeWork + weightedQuiz + weightedExam;
        //output total score as number
        Console.WriteLine(studentName + "'s total WEIGHTED score: " + totalWeighted + "%");
        //determine letter grade based on totalWeighted
        switch (totalWeighted)
        {
          //A
          case >=90: 
            Console.WriteLine(studentName + "'s Leter Grade is A");
            break;
//?why do I need to use and vs &&?
          //B
          case <90 and >=80: 
            Console.WriteLine(studentName + "'s Leter Grade is B");
            break;
          //C
          case <80 and >=70: 
            Console.WriteLine(studentName + "'s Leter Grade is C");
            break;
          //D
          case <70 and >=60: 
            Console.WriteLine(studentName + "'s Leter Grade is D");
            break;
          case <60: 
          //F
            Console.WriteLine(studentName + "'s Leter Grade is F");
            break;
          //not able to calc
          default: 
            Console.WriteLine("Letter grade can not be determined.");
            break;
        }
      }  //end per student loop 
    }
  }
}
