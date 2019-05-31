using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entryNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            foreach (var item in entryNumbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
