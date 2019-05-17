using System;

namespace Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceEasterBread = 4.00;
            double priceEgg = 0.45;

            double numOfEasterBread = Math.Ceiling(countGuests / 3.0);
            double numOfEggs = Math.Ceiling(countGuests * 2.0);

            double finalPriceEasterBread = numOfEasterBread * priceEasterBread;
            double finalPriceEggs = numOfEggs * priceEgg;

            double finalPrice = finalPriceEasterBread + finalPriceEggs;

            double diff = Math.Abs(budget - finalPrice);

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Lyubo bought {numOfEasterBread} Easter bread and {numOfEggs} eggs.");
                Console.WriteLine($"He has {diff:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {diff:f2} lv. more.");
            }
        }
    }
}
