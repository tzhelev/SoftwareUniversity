using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2, 3, 6, 7, 10

            int num = int.Parse(Console.ReadLine());
            int devider = 0;
            bool divisible = false;

            if (num % 10 == 0)
            {
                divisible = true;
                devider = 10;
            }
            else if (num % 7 == 0)
            {
                divisible = true;
                devider = 7;
            }
            else if (num % 6 == 0)
            {
                divisible = true;
                devider = 6;
            }
            else if (num % 3 == 0)
            {
                divisible = true;
                devider = 3;
            }
            else if (num % 2 == 0)
            {
                divisible = true;
                devider = 2;
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

            if (divisible)
            {
                Console.WriteLine($"The number is divisible by {devider}");
            }
        }
    }
}
