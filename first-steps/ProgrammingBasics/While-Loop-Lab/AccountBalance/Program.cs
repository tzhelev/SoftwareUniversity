using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double sum = 0;
            int count = 0;


            while (count < n)
            {
                double currentSum = double.Parse(Console.ReadLine());

                if (currentSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {currentSum:f2}");

                sum += currentSum;
                count++;
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
