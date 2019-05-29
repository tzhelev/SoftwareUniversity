using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());

            int snow = 0;
            int time = 0;
            int quality = 0;
            BigInteger bestSnowball = 0;
            

            for (int i = 0; i < snowballCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= bestSnowball)
                {
                    bestSnowball = snowballValue;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;

                }
            }

            Console.WriteLine($"{snow} : {time} = {bestSnowball} ({quality})");

        }
    }
}
