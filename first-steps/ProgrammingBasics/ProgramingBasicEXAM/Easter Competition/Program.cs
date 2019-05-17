using System;

namespace Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChefs = int.Parse(Console.ReadLine());
            string winningChef = string.Empty;
            int maxPoints = int.MinValue;

            for (int i = 0; i < countChefs; i++)
            {
                string nameChef = Console.ReadLine();
                int currentPoints = 0;
                bool newWinner = false;
                string command = string.Empty;

                while ((command = Console.ReadLine()) != "Stop")
                {
                    int points = int.Parse(command);
                    currentPoints += points;
                    if (currentPoints > maxPoints)
                    {
                        maxPoints = currentPoints;
                        winningChef = nameChef;
                        newWinner = true;
                    }
                    
                }
                Console.WriteLine($"{nameChef} has {currentPoints} points.");

                if (newWinner)
                {
                    Console.WriteLine($"{nameChef} is the new number 1!");
                }


            }
            Console.WriteLine($"{winningChef} won competition with {maxPoints} points!");
        }
    }
}
