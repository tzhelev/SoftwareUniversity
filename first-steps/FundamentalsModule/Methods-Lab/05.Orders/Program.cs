using System;

namespace _05.Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            double quatity = double.Parse(Console.ReadLine());

            CalculatePrice(product, quatity);
        }

        static void CalculatePrice(string product, double quatity)
        {
            double result = 0d;

            switch (product)
            {
                case "coffee":
                    result = quatity * 1.5;
                    break;
                case "water":
                    result = quatity * 1.0;
                    break;
                case "coke":
                    result = quatity * 1.4;
                    break;
                case "snacks":
                    result = quatity * 2.0;
                    break;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
