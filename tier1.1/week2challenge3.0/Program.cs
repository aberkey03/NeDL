using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int index=0;
            string[] rNameArr = new string [25];
            string[] rRateArr = new string [25];
            using (StreamReader sr = File.OpenText("restRate.txt"))
                {
                    string rName = "";
                    string rRate = "";
                    Console.WriteLine("Here is the content of the file restRate.txt: ");
                    while ((rName = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(rName);
                        rNameArr[index]=rName;
                        
                        rRate=sr.ReadLine();
                        Console.WriteLine(rRate);
                        rRateArr[index]=rRate;

                        index=index+1;
                        if (index==25)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("");
                }
        }
    }
}

