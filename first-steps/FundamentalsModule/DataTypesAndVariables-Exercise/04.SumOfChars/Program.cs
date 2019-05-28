using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int sumOfChars = 0;

            for (int i = 0; i < loop; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sumOfChars += symbol;
            }

            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
