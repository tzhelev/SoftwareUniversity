using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double startPoints = int.Parse(Console.ReadLine());
            double addPoints = 0.0;

            while (startPoints < 101)
            {
                addPoints += 5;
                break;
            }
            while (startPoints > 99 && startPoints < 1001)
            {
                addPoints = startPoints * 0.20;
                break;
            }
            while (startPoints > 999)
            {
                addPoints = startPoints * 0.10;
                break;
            }
            while (startPoints % 2 == 0)
            {
                addPoints += 1;
                break;
            }
            while (startPoints % 10 == 5)
            {
                addPoints += 2;
                break;
            }

            double points = startPoints + addPoints;

            Console.WriteLine(addPoints);
            Console.WriteLine(points);

        }
    }
}
