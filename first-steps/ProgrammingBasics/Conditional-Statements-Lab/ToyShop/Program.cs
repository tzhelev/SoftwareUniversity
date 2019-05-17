using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfTrip = double.Parse(Console.ReadLine());
            int countPuzzle = int.Parse(Console.ReadLine());
            int countDolls = int.Parse(Console.ReadLine());
            int countBears = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTruks = int.Parse(Console.ReadLine());

            int countOfToys = countPuzzle + countDolls + countBears + countMinions + countTruks;

            double allPuzzle = 0;
            double allDolls = 0;
            double allBears = 0;
            double allMinions = 0;
            double allTruks = 0; 

            if (countPuzzle > 0)
            {
                allPuzzle = countPuzzle * 2.6;
            }
                 if (countDolls > 0)
                 {
                   allDolls = countDolls * 3.0;
                 }
                    if (countBears > 0)
                    {
                      allBears = countBears * 4.1;
                    }
                        if (countMinions > 0)
                        {
                          allMinions = countMinions * 8.2;
                        }
                            if (countTruks > 0)
                            {
                                allTruks = countTruks * 2.0;
                            }
            double finalPrice = allPuzzle + allDolls + allBears + allMinions + allTruks;

            if (countOfToys > 49)
            {
                finalPrice = finalPrice - (finalPrice * 0.25);
            }

            finalPrice = finalPrice - (finalPrice * 0.10);
            double difference = Math.Abs(finalPrice - priceOfTrip);

            if (finalPrice >= priceOfTrip)
            {
                
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}