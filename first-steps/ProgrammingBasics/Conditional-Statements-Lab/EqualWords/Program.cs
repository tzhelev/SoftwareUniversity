using System;
using System.Globalization;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1 = Console.ReadLine();
            string w2 = Console.ReadLine();

            w1 = w1.ToUpper();
            w2 = w2.ToUpper();

            if (w1 == w2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
