using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            uint.TryParse(Console.ReadLine(), out uint number);

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;ewflkg
                int digits = i;

                while (digits > 0)
                {
                    sum += digits % 10;
                    digits /= 10;
                }
                bool isSpecial = (sum % 5 == 0 && sum != 10) || sum % 7 == 0 || sum % 11 == 0;
                Console.WriteLine($"{i} -> {isSpecial}");

            }
        }
    }
}
