using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            double availableMoney = 0.0;



            while ((command = Console.ReadLine()) != "Start")
            {
                bool notStart = double.TryParse(command, out double coins);
                bool acceptedCoins = coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2;
                if (acceptedCoins)
                {
                    availableMoney += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            while ((command = Console.ReadLine()) != "End")
            {
                bool doIHaveMoney = (availableMoney < 1.0 && command.ToLower() == "coke") ||
                    (availableMoney < 0.7 && command.ToLower() == "water") ||
                    (availableMoney < 1.5 && command.ToLower() == "crisps") ||
                    (availableMoney < 0.8 && command.ToLower() == "soda") ||
                    (availableMoney < 2.0 && command.ToLower() == "nuts");
               
                if (doIHaveMoney)
                {
                    Console.WriteLine($"Sorry, not enough money");
                    break;
                }
                switch (command.ToLower())
                {
                    case "coke": availableMoney -= 1.0; Console.WriteLine($"Purchased {command.ToLower()}"); break;
                    case "water": availableMoney -= 0.7; Console.WriteLine($"Purchased {command.ToLower()}"); break;
                    case "crisps": availableMoney -= 1.5; Console.WriteLine($"Purchased {command.ToLower()}"); break;
                    case "soda": availableMoney -= 0.8; Console.WriteLine($"Purchased {command.ToLower()}"); break;
                    case "nuts": availableMoney -= 2.0; Console.WriteLine($"Purchased {command.ToLower()}"); break;
                    default: Console.WriteLine("Invalid product"); break;

                }
                if (availableMoney <= 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Change: {availableMoney:f2}");
        }
    }
}
