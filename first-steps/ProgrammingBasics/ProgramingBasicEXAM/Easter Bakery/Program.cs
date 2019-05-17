using System;

namespace Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double price1kgFlour = double.Parse(Console.ReadLine());
            double kilogramsFlour = double.Parse(Console.ReadLine());
            double kilogramsSugar = double.Parse(Console.ReadLine());
            double barkOfEggs = double.Parse(Console.ReadLine());
            double pocketsMay = double.Parse(Console.ReadLine());

            double priceSugar = price1kgFlour * 0.75;
            double priceEggs = price1kgFlour * 1.10;
            double priceMay = priceSugar * 0.20;

            double finalPriceFlour = price1kgFlour * kilogramsFlour;
            double finalPriceSugar = kilogramsSugar * priceSugar;
            double finalPriceEggs = barkOfEggs * priceEggs;
            double finalPriceMay = pocketsMay * priceMay;

            double finalPrice = finalPriceEggs + finalPriceFlour + finalPriceMay + finalPriceSugar;

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
