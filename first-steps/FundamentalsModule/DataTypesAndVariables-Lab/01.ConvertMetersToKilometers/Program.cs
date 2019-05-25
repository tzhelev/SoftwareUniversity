using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort givenMeters = ushort.Parse(Console.ReadLine());

            double kilometers = (double)givenMeters / 1000;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
