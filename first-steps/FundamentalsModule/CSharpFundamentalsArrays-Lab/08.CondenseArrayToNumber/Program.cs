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
        }
    }
}