using System;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxPoints = int.MinValue;
            string winnerName = string.Empty;
            int sumOfPointsForLastName = 0;


            while (name != "STOP")
            {
                name = Console.ReadLine();
                sumOfPointsForLastName = 0;
                
                for (int i = 0; i < name.Length; i++)
                {
                    int points = name[i];
                    sumOfPointsForLastName += points;
                }
                if (sumOfPointsForLastName > maxPoints && name != "STOP")
                {
                    maxPoints = sumOfPointsForLastName;
                    winnerName = name;
                }
            }
            Console.WriteLine($"Winner is {winnerName} - {maxPoints}!");
        }
    }
}
