using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        price = count * 0.5;
                        break;
                    case "water":
                        price = count * 0.8;
                        break;
                    case "beer":
                        price = count * 1.2;
                        break;
                    case "sweets":
                        price = count * 1.45;
                        break;
                    case "peanuts":
                        price = count * 1.6;
                        break;
                }
            }
            if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        price = count * 0.4;
                        break;
                    case "water":
                        price = count * 0.7;
                        break;
                    case "beer":
                        price = count * 1.15;
                        break;
                    case "sweets":
                        price = count * 1.30;
                        break;
                    case "peanuts":
                        price = count * 1.50;
                        break;
                }
            }
            if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        price = count * 0.45;
                        break;
                    case "water":
                        price = count * 0.7;
                        break;
                    case "beer":
                        price = count * 1.1;
                        break;
                    case "sweets":
                        price = count * 1.35;
                        break;
                    case "peanuts":
                        price = count * 1.55;
                        break;
                }
            }
            Console.WriteLine(price);
        }
    }
}
