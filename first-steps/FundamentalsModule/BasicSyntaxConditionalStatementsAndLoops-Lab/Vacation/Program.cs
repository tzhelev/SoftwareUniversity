using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0.0;

            if (typeOfGroup == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price += 8.45; break;
                    case "Saturday": price += 9.8; break;
                    case "Sunday": price += 10.46; break;
                }
            }
            else if (typeOfGroup == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price += 10.9; break;
                    case "Saturday": price += 15.6; break;
                    case "Sunday": price += 16; break;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price += 15; break;
                    case "Saturday": price += 20; break;
                    case "Sunday": price += 22.5; break;
                }
            }

            double finalPrice = price * group;

            if (group >= 30 && typeOfGroup == "Students")
            {
                finalPrice *= 0.85;
            }
            else if (group >= 100 && typeOfGroup == "Business")
            {
                finalPrice -= price * 10;
            }
            else if (group >= 10 && group <= 20 && typeOfGroup == "Regular")
            {
                finalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}