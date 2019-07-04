using System;
using System.Collections.Generic;
using System.Linq;

namespace SeizeTheFire
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split("#").ToList();
            int water = int.Parse(Console.ReadLine());
            int sumOfCells = 0;
            double effort = 0.0;

            List<string> separateInput = new List<string>();

            Console.WriteLine("Cells:");

            for (int i = 0; i < input.Count; i++)
            {
                separateInput = input[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int currentCell = int.Parse(separateInput[1].Trim());

                bool highLevelRange = currentCell >= 81 && currentCell <= 125; 
                bool mediumLevelRange = currentCell >= 51 && currentCell <= 80; 
                bool lowLevelRange = currentCell >= 1 && currentCell <= 50; 

                if (separateInput[0].Contains("High"))
                {
                    if (!highLevelRange)
                    {
                        continue;
                    }

                    if (water < currentCell)
                    {
                        continue;
                    }

                    water -= currentCell;                   
                    effort += currentCell * 0.25;
                    sumOfCells+=currentCell;

                    Console.WriteLine($" - {currentCell}");
                }

                if (separateInput[0].Contains("Medium"))
                {
                    if (!mediumLevelRange)
                    {
                        continue;
                    }

                    if (water < currentCell)
                    {
                        continue;
                    }

                    water -= currentCell;                   
                    effort += currentCell * 0.25;
                    sumOfCells+=currentCell;

                    Console.WriteLine($" - {currentCell}");

                }

                if (separateInput[0].Contains("Low"))
                {
                    if (!lowLevelRange)
                    {
                        continue;
                    }

                    if (water < currentCell)
                    {
                        continue;
                    }

                    water -= currentCell;                   
                    effort += currentCell * 0.25;
                    sumOfCells+=currentCell;

                    Console.WriteLine($" - {currentCell}");
                }
            }

            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {sumOfCells}");
           
        }
    }
}
