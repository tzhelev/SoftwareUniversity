using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            double ivanTime = meters * timeInSec;
            double waterResistane = Math.Floor(meters / 15) * 12.5;
            ivanTime += waterResistane;

            double difference = Math.Abs(worldRecord - ivanTime);

            if (ivanTime < worldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
        }
    }
}
