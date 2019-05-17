using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num > 199 && num <= 399)
                {
                    p2++;
                }
                else if (num > 399 && num <= 599)
                {
                    p3++;
                }
                else if (num > 599 && num <= 799)
                {
                    p4++;
                }
                else if (num > 799)
                {
                    p5++;
                }
            }
            double p1Res = (p1 / n) * 100;
            double p2Res = (p2 / n) * 100;
            double p3Res = (p3 / n) * 100;
            double p4Res = (p4 / n) * 100;
            double p5Res = (p5 / n) * 100;

            Console.WriteLine($"{p1Res:f2}%");
            Console.WriteLine($"{p2Res:f2}%");
            Console.WriteLine($"{p3Res:f2}%");
            Console.WriteLine($"{p4Res:f2}%");
            Console.WriteLine($"{p5Res:f2}%");
        }
    }
}
