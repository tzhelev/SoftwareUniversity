using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main()
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal firstNumberFactorial = CalculateFactorial(firstNumber);
            decimal secondNumberFactorial = CalculateFactorial(secondNumber);

            decimal result = DivideTwoNumbers(firstNumberFactorial, secondNumberFactorial);

            Console.WriteLine($"{result:f2}");
        }

        private static decimal DivideTwoNumbers(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber/secondNumber;
        }

        private static decimal CalculateFactorial(decimal number)
        {
            decimal sumFact = 1;

            for (decimal i = 1; i <= number; i++)
            {
                sumFact *= i;
            }

            return sumFact;
        }
    }
}
