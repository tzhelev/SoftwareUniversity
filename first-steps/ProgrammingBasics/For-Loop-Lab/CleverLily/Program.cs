using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilysAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toyCount = 0;
            int moneyGift = 9;
            int savedMoney = 0;

            

            for (int i = 1; i <= lilysAge; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += moneyGift;
                    moneyGift += 10;
                }
                else
                {
                    toyCount++;
                }
            }

            double moneyFromToys = toyCount * toyPrice;
            double allSavedMoney = moneyFromToys + savedMoney;
            double diff = Math.Abs(allSavedMoney - washingMachinePrice);

            if (allSavedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}