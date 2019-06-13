using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculationType = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (calculationType)
            {
                case "add": Sum(number1, number2); break;
                case "multiply": Multiply(number1, number2); break;
                case "divide": Divide(number1, number2); break;
                case "subtract": Subtract(number1, number2); break;
            }
        }

        static void Sum(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        static void Divide(int n1, int n2)
        {
            if (n2 != 0)
            {
                Console.WriteLine(n1 / n2);
            }
        }

        static void Multiply(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }

        static void Subtract(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
    }
}
