using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            bool weekDay = day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday";
            bool weekEnd = day == "Sunday" || day == "Saturday";

            double price = 0.0;

            if (weekDay)
            {
                switch (fruit)
                {
                    case "banana": price = count * 2.5; break;
                    case "apple": price = count * 1.2; break;
                    case "orange": price = count * 0.85; break;
                    case "grapefruit": price = count * 1.45; break;
                    case "kiwi": price = count * 2.7; break;
                    case "pineapple": price = count * 5.5; break;
                    case "grapes": price = count * 3.85; break;
                }
            }
            if (weekEnd)
            {
                switch (fruit)
                {
                    case "banana": price = count * 2.7; break;
                    case "apple": price = count * 1.25; break;
                    case "orange": price = count * 0.9; break;
                    case "grapefruit": price = count * 1.6; break;
                    case "kiwi": price = count * 3.0; break;
                    case "pineapple": price = count * 5.6; break;
                    case "grapes": price = count * 4.2; break;
                }

            }
            if (price > 0)
                Console.WriteLine($"{price:f2}");
            else
                Console.WriteLine("error");

        }
    }
}
