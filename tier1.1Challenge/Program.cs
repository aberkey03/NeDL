using System;

namespace CustomerMemberships
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regular");
            Regular regular1 = new Regular(1111, "regular1@gmail.com", "Regular", 100.00, 300.00);
            Console.WriteLine(regular1);

            Console.WriteLine("After purchase");
            regular1.Purchase(50);
            Console.WriteLine(regular1);

            Console.WriteLine("After return");
            regular1.Return(100);
            Console.WriteLine(regular1);

            Console.WriteLine("Cash back");
            regular1.ApplyCashBack();
        }
    }
}