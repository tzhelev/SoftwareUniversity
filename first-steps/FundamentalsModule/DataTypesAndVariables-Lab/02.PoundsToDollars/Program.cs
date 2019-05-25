using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort givenPounds = ushort.Parse(Console.ReadLine());

            double dollars = (double)givenPounds * 1.31;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
