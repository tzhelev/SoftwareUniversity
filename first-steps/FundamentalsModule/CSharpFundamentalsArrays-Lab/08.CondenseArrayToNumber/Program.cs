using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] processedNumbers = new int[givenNumbers.Length - 1];

            while (givenNumbers.Length > 1)
            {
                int[] processedNumbers = new int[givenNumbers.Length - 1];
                for (int i = 0; i < givenNumbers.Length - 1; i++)
                {
                    processedNumbers[i] = givenNumbers[i] + givenNumbers[i + 1];
                }
                givenNumbers = processedNumbers;
            }
            Console.WriteLine(givenNumbers[0]);
        }
    }
}