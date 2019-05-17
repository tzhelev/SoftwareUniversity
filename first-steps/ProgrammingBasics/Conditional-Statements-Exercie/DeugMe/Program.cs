using System;

namespace DeugMe
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine()); // трябва да е double, а е int

            double timeInSeconds = distance * timePerMeter; //заменяме * 25 с timePerMeter 
            double additionalSeconds = (distance / 50);
            additionalSeconds = Math.Ceiling(additionalSeconds); // Math.Floor
            additionalSeconds *= 30;
            double totalTime = timeInSeconds + additionalSeconds;

            if (worldRecord <= totalTime)  // >
            {
                Console.WriteLine($"Yes! The new record is {totalTime} seconds."); // закръгляне до 2 знак
            }
            else
            {
                Console.WriteLine($"No! He was {Math.Abs(worldRecord - totalTime):f2} seconds slower.");
            }
        }
    }
}
