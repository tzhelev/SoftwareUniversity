using System;

namespace Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeEggs = Console.ReadLine();
            string colorEggs = Console.ReadLine();
            int countBatch = int.Parse(Console.ReadLine());

            double priceEggs = 0.0; 

            for (int i = 0; i < countBatch; i++)
            {
                if (sizeEggs == "Large")
                {
                    switch (colorEggs)
                    {
                        case "Red": priceEggs += 16.00; break;
                        case "Green": priceEggs +=12.00; break;
                        case "Yellow": priceEggs +=9.00; break;
                    }
                }
                if (sizeEggs == "Medium")
                {
                    switch (colorEggs)
                    {
                        case "Red": priceEggs +=13.00; break;
                        case "Green": priceEggs +=9.00; break;
                        case "Yellow": priceEggs +=7.00; break;
                    }
                }
                if (sizeEggs == "Small")
                {
                    switch (colorEggs)
                    {
                        case "Red": priceEggs +=9.00; break;
                        case "Green": priceEggs +=8.00; break;
                        case "Yellow": priceEggs +=5.00; break;
                    }
                }
            }

            double finalMoney = priceEggs * 0.65;

            Console.WriteLine($"{finalMoney:f2} leva.");
           
        }
    }
}
