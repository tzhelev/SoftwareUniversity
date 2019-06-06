using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = numbers.Sum();
            bool isEqual = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (leftSum == rightSum - numbers[i])
                {
                    isEqual = true;
                    Console.WriteLine(i);
                    break;
                }
                leftSum += numbers[i];
                rightSum -= numbers[i];
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        } 
    }
}
