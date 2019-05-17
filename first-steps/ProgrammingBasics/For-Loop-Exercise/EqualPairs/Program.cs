using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            double sum = 0.0;
            double lastSum = 0.0;
            double diff = 0.0;

            for (int i = 0; i < loop; i++)
            {
                double fNum = double.Parse(Console.ReadLine());
                double sNum = double.Parse(Console.ReadLine());
                sum = fNum + sNum;

                if (i > 0)
                {
                    diff = lastSum - sum;
                    diff = Math.Abs(diff);
                }

                lastSum = sum;
            }

            if (diff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else if (diff != 0)
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
