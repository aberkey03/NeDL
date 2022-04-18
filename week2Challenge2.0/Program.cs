using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {        
        
        int[,] A = new int[5, 4];

        //read
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                A[i, j] = int.Parse(Console.ReadLine());  
            }
        }

        //Write
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine();

            for (int j = 0; j < 4; j++)
            {
                Console.Write(A[i, j]);
            }
        }
    }
  }
}