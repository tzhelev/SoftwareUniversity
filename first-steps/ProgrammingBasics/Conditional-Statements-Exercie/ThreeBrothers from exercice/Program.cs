using System;

namespace ThreeBrothers_from_exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double timeFishing = double.Parse(Console.ReadLine());

            double CleaningTime = 1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime);
            double timeWithRest = CleaningTime * 1.15;

            double timeLeft = timeWithRest - timeFishing;

            Console.WriteLine($"Cleaning time: {timeWithRest:f2}");

            if (timeLeft >= timeFishing)
            {
                timeLeft = Math.Floor(timeLeft);
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeLeft} hours");
            }
            else
            {
                timeLeft = Math.Abs(Math.Ceiling(timeLeft));
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeLeft} hours.");
            }

        }
    }
}
