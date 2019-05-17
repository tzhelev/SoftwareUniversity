using System;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfEggs = int.Parse(Console.ReadLine());
            int redEgg = 0;
            int orangeEgg = 0;
            int blueEgg = 0;
            int greenEgg = 0;

            int maxEggs = int.MinValue;
            string maximumEgg = string.Empty;

            for (int i = 0; i < countOfEggs; i++)
            {
                string eggColor = Console.ReadLine();

                switch (eggColor)
                {
                    case "red": redEgg++; break;
                    case "orange": orangeEgg++; break;
                    case "blue": blueEgg++; break;
                    case "green": greenEgg++; break;
                }


            }

            if (redEgg > maxEggs)
            {
                maxEggs = redEgg;
                maximumEgg = "red";
            }
            if (orangeEgg > maxEggs)
            {
                maxEggs = orangeEgg;
                maximumEgg = "orange";
            }
            if (blueEgg > maxEggs)
            {
                maxEggs = blueEgg;
                maximumEgg = "blue";
            }
            if (greenEgg > maxEggs)
            {
                maxEggs = greenEgg;
                maximumEgg = "green";
            }

            Console.WriteLine($"Red eggs: {redEgg}");
            Console.WriteLine($"Orange eggs: {orangeEgg}");
            Console.WriteLine($"Blue eggs: {blueEgg}");
            Console.WriteLine($"Green eggs: {greenEgg}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maximumEgg}");
        }
    }
}