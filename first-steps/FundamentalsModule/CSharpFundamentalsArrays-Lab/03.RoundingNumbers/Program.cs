using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] entryNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < entryNumbers.Length; i++)
            {
                double result = Math.Round(entryNumbers[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{entryNumbers[i]} => {result}");
                
            }
        }
    }
}
