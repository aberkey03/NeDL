using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample1
{
    public class LogLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside the Log method of LogLogger");
            LogToLogLogger(message);
        }
        
        private void LogToLogLogger(string message)
        {
            Console.WriteLine("Method: LogToLogLogger, Text: ", message);
        }
    }
}
