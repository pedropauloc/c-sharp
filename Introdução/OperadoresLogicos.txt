using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            bool c1 = 2 > 3 || 4 != 5; // TRUE
            bool c2 = !(2 > 3) && 4 != 5; // TRUE

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            bool c3 = 10 < 5; // false
            bool c4 = c1 || c2 && c3; // true

            Console.WriteLine(c3);
            Console.WriteLine(c4);

        }
    }
}