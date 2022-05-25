using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample1
{
    public class ProductService
    {
        //private readonly FileLogger _fileLogger = new FileLogger();
        //private readonly DatabaseLogger _databaseLogger = new DatabaseLogger();
        //public void LogtoFile(string message)
        //{
        //    _fileLogger.Log(message);
        //}
        //public void LogToDatabase(string message)
        //{
        //    _fileLogger.Log(message);
        //}

        private readonly ILogger _logger;

        public ProductService(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log(message);
        }

    }
}
