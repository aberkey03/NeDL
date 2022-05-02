using System;

namespace CustomerMemberships
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Regular");
            Regular regular1 = new Regular(1111, "regular1@gmail.com", "Regular", 100.00, 300.00);
            Console.WriteLine(regular1);

            Console.WriteLine("After purchase");
            regular1.Purchase(50);
            Console.WriteLine(regular1);

            Console.WriteLine("After return");
            regular1.Return(100);
            Console.WriteLine(regular1);

            Console.WriteLine("Cash back");
            regular1.ApplyCashBack(); */

            Console.WriteLine("Executive");
            Executive executive1 = new Executive(2222, "executive1@gmail.com", "Executive", 200, 700);
            Console.WriteLine(executive1);

            Console.WriteLine("After purchase");
            executive1.Purchase(50);
            Console.WriteLine(executive1);

            Console.WriteLine("After return");
            executive1.Return(100);
            Console.WriteLine(executive1);

            Console.WriteLine("Cash back");
            executive1.ApplyCashBack();

            Console.WriteLine("Executive2");
            Executive executive2 = new Executive(2233, "executive2@gmail.com", "Executive", 200, 2000);
            Console.WriteLine(executive2);

            Console.WriteLine("Cash back");
            executive2.ApplyCashBack();
        }
    }
}