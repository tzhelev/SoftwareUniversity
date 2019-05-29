using System;
using System.Numerics;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            int daysCount = 0;
            uint currentYield = 0;

            while (startingYield > 99 )
            {
                currentYield += startingYield;
                if (currentYield > 25)
                {
                    currentYield -= 26;
                }
                else
                {
                    currentYield = 0;
                }
                
                startingYield -= 10;
                daysCount++;
            }

            if (daysCount > 0)
            {
                currentYield -= 26;
            }
            
            Console.Write($"{daysCount}\n{currentYield}");

        }
    }
}
