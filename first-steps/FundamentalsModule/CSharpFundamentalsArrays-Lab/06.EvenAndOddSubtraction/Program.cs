using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entryNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            foreach (var item in entryNumbers)
            {
                bool isEven = item % 2 == 0;
                if (isEven)
                {
                    evenSum += item;
                }
                else
                {
                    oddSum += item;
                }
            }
            int result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
