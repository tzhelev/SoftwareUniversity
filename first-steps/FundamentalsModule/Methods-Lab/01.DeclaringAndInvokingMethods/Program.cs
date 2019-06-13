using System;

namespace _01.DeclaringAndInvokingMethods
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            NegativeOrPositive(number);
        }

        static void NegativeOrPositive (int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
