﻿using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < count; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += n;
                }
                else
                {
                    oddSum += n;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else if (evenSum != oddSum)
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
