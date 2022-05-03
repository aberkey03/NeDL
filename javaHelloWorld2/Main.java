import java.io.*;

public class Main 
{
  public static void main(String[] args) 
  {
    // Create the console object
    //this is need to read user input to the console
    Console cnsl = System.console();
    if (cnsl == null) 
    {
      System.out.println("No console available");
      return;
    }

    boolean positiveStudents = false;
    int numberStudentsInt;
    int numHomework = 5;
    int numQuizes = 3;
    int numExams = 2;

    do
    {
      //prompt for number of students
      System.out.println("enter the number of students (must be greater than 0)");
      //read line
      String numberStudentsString = cnsl.readLine();
      //convert string to int
      numberStudentsInt = Integer.parseInt(numberStudentsString);
    
      //verify greater than 0
      if (numberStudentsInt <= 0)
      {
        System.out.println("number of students (must be greater than 0)");
        positiveStudents = false;
      }
      else
      {
        System.out.println("number of students is enough");
        positiveStudents =  true;
      }
    } while (positiveStudents == false);
    
    //loop through each student
    for (int studentIndex = 0; studentIndex < numberStudentsInt; studentIndex++)
    {
      //prompt for name
      System.out.println("Enter student " + studentIndex + "'s name.");
      String studentName = cnsl.readLine();
      
      //prompt for 5 homework grades, and verify scores is greater than -1
      int homeWorkTotal = 0;
      for (int homeWorkIndex = 0; homeWorkIndex < numHomework; homeWorkIndex++)
      {
        boolean homeWorkScorePositive = false;
        do
        {
          //prompt for homework score
          System.out.println("Enter homework score " + homeWorkIndex);
          //read line
          int homeWorkScore = Integer.parseInt(cnsl.readLine());
          //verify greater than 0
          if (homeWorkScore <= -1)
          {
            System.out.println("score must be greater than -1");
            homeWorkScorePositive = false;
          }
          else
          {
            System.out.println("score is positve");
            homeWorkTotal = homeWorkTotal + homeWorkScore;
            homeWorkScorePositive =  true;
          }
        } while (homeWorkScorePositive == false);
        
      }
      

      //prompt for 3 quizes and verify scores is greater than -1
    
      int quizTotal = 0;
      for (int quizIndex = 0; quizIndex < numQuizes; quizIndex++)
      {
        boolean quizScorePositive = false;
        do
        {
          //prompt for homework score
          System.out.println("Enter quiz score " + quizIndex);
          //read line
          int quizScore = Integer.parseInt(cnsl.readLine());
          //verify greater than 0
          if (quizScore <= -1)
          {
            System.out.println("score must be greater than -1");
            quizScorePositive = false;
          }
          else
          {
            System.out.println("score is positve");
            quizTotal = quizTotal + quizScore;
            quizScorePositive =  true;
          }
        } while (quizScorePositive == false);
        
      }
      //prompt for 2 exams
      int examTotal = 0;
      for (int examIndex = 0; examIndex < numExams; examIndex++)
      {
        boolean examScorePositive = false;
        do
        {
          //prompt for homework score
          System.out.println("Enter exam score " + examIndex);
          //read line
          int examScore = Integer.parseInt(cnsl.readLine());
          //verify greater than 0
          if (examScore <= -1)
          {
            System.out.println("score must be greater than -1");
            examScorePositive = false;
          }
          else
          {
            System.out.println("score is positve");
            examTotal = examTotal + examScore;
            examScorePositive =  true;
          }
        } while (examScorePositive == false);
        
      }

      //calc final weighted score
        //homework = 50%
        //quizes = 30%
        //exams = 20%

      //display name, hw avg, quix avg, exam svg, total avg, and letter grade
      System.out.println(studentName + "'s homework total:" + homeWorkTotal);
      System.out.println(studentName + "'s quiz total:" + quizTotal);
      System.out.println(studentName + "'s exam total:" + examTotal);

      //calc avgs
      int homeWorkAvg = homeWorkTotal / numHomework;
      int quizAvg = quizTotal / numQuizes;
      int examAvg = examTotal / numExams;

      System.out.println(studentName + "'s homework average:" + homeWorkAvg);
      System.out.println(studentName + "'s quiz average:" + quizAvg);
      System.out.println(studentName + "'s exam average:" + examAvg);

      //calc wiegthed avgs
      double weightedHomeWorkAvg = homeWorkAvg * .5;
      double weightedQuizAvg = quizAvg * .3;
      double weightedExamAvg = examAvg * .2;
      double totalWeightedScore = weightedHomeWorkAvg + weightedQuizAvg + weightedExamAvg;
      System.out.println(studentName + "'s total weighted:" + totalWeightedScore);

      char letterGrade = 'Z';
      if (totalWeightedScore >= 90.0)
      {
        letterGrade = 'A';
      }
      else if (totalWeightedScore >= 80.0 && totalWeightedScore < 90)
      {
        letterGrade = 'B';
      }
      else if (totalWeightedScore >= 70.0 && totalWeightedScore < 80)
      {
        letterGrade = 'C';
      }
      else if (totalWeightedScore >= 60.0 && totalWeightedScore < 70)
      {
        letterGrade = 'D';
      }
      else if (totalWeightedScore < 60)
      {
        letterGrade = 'F';
      }
      System.out.println(studentName + "'s letter grade:" + letterGrade);

    } //end per student loop
  } // end main method
} // end Main class