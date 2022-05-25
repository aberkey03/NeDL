using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample1
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of FileLogger");
            LogToFile(message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("Method: LogToFile, Text: {0}", message);
        }
    }
}
