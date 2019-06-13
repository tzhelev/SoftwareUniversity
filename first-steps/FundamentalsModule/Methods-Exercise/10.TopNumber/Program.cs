using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

           PrintConainingMasterNumbers(number);
        }

        private static bool IsHoldingOddDigit(int number)
        {

            bool haveOdd = false;

            while (number != 0)
            {
                int digit = number % 10;

                if (digit % 2 == 1)
                {
                    return haveOdd = true;
                }
                else
                {
                    haveOdd = false;
                }

                number /= 10;
            }

            return haveOdd;
        }

        private static bool IsSumDivisibleByEight(int number)
        {
            int sumDigits = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sumDigits += digit;
                number /= 10;
            }

            bool isDivisible;

            if (sumDigits % 8 == 0)
            {
                isDivisible = true;
            }
            else
            {
                isDivisible = false;
            }

            return isDivisible;
        }

        private static void PrintConainingMasterNumbers(int number)
        {
             for (int i = 1; i <= number; i++)
            {
                bool isTopByDivision = IsSumDivisibleByEight(i);
                bool isHoldingOddDigit = IsHoldingOddDigit(i);


                if (isTopByDivision && isHoldingOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
