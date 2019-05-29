using System;
using System.Numerics;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte loop = byte.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string result = string.Empty;

            for (int i = 0; i < loop; i++)
            {
                string nameOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightOgKeg = int.Parse(Console.ReadLine());
                double volumeOfKeg = Math.PI * Math.Pow(radiusOfKeg, 2) * heightOgKeg;

                if (biggestKeg < volumeOfKeg)
                {
                    result = nameOfKeg;
                    biggestKeg = volumeOfKeg;
                }
            }
            Console.WriteLine(result);


        }
    }
}
