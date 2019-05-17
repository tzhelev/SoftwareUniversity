using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }

            }
            double p1Res = (p1 / n) * 100;
            double p2Res = (p2 / n) * 100;
            double p3Res = (p3 / n) * 100;

            Console.WriteLine($"{p1Res:f2}%");
            Console.WriteLine($"{p2Res:f2}%");
            Console.WriteLine($"{p3Res:f2}%");
        }
    }
}
