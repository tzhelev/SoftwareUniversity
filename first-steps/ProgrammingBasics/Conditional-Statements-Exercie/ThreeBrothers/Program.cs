using System;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double timeFishing = double.Parse(Console.ReadLine());

            double CleaningTime = firstBrotherTime + secondBrotherTime + thirdBrotherTime ;
            
            double allCleaningTime = CleaningTime / (CleaningTime / firstBrotherTime + CleaningTime / secondBrotherTime + CleaningTime / thirdBrotherTime);
            allCleaningTime *= 1.15;

            Console.WriteLine($"Cleaning time: {allCleaningTime:f2}");

            double timeLeft = Math.Abs(allCleaningTime - timeFishing);

            if (allCleaningTime <= timeFishing)
            {
                timeLeft = Math.Floor(timeLeft);
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeLeft} hours.");
            }
            else
            {
                timeLeft = Math.Ceiling(timeLeft);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeLeft} hours.");
            }
        }
    }
}
