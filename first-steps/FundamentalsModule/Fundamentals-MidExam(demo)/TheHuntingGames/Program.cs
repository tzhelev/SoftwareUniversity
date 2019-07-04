using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main()
        {
            int daysCount = int.Parse(Console.ReadLine());
            double playersCount = double.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterForOne = double.Parse(Console.ReadLine());
            double foodForOne = double.Parse(Console.ReadLine());
            bool isEnaughEnergy = true;
            double currentWater = daysCount * playersCount * waterForOne;
            double currentFood = daysCount * playersCount * foodForOne;

            for (int day = 1; day <= daysCount; day++)
            {
                double energyLos = double.Parse(Console.ReadLine());

                groupEnergy -= energyLos;

                if (groupEnergy <= 0)
                {
                    isEnaughEnergy = false;
                    break;
                }


                bool secondDay = day % 2 == 0;

                if (secondDay)
                {
                    groupEnergy *= 1.05;
                    currentWater *= 0.7;
                }


                bool thirdDay = day % 3 == 0;

                if (thirdDay)
                {
                    currentFood -= currentFood / playersCount; 
                    groupEnergy *= 1.1;
                }


            }

            if (isEnaughEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {currentFood:f2} food and {currentWater:f2} water.");
            }
        }
    }
}
