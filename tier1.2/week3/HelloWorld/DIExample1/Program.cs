using System;

namespace DIExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new LogLogger();

            ProductService productService = new ProductService(logger);

            productService.Log("Hello world!");


        }
    }
}
