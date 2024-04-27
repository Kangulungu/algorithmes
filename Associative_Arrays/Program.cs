using System;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(5);
            double d;

            a["d"] = 6; a["e"] = 7.0; a["f"] = 8.0;

            d = a["e"] + a["f"];   // corresponds to d = a.d + a.e 
                                   // in case d and e had been public

            Console.WriteLine("a: {0}, d: {1}", a, d);
            Console.ReadLine();

        }
    }
}
