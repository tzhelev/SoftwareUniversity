using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int daysCounter = 0;

            while (availableMoney < moneyForVacation)
            {
                string saveOrSpend = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());


                if (saveOrSpend == "save")
                {
                    availableMoney += amount;
                    spendCounter = 0;
                }
                else if (saveOrSpend == "spend")
                {
                    if (amount > availableMoney)
                    {
                        amount = availableMoney;
                    }

                    availableMoney -= amount;
                    spendCounter++;
                }

                daysCounter++;

                if (spendCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCounter}");
                    break;
                }
            }

            if (availableMoney >= moneyForVacation)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}

