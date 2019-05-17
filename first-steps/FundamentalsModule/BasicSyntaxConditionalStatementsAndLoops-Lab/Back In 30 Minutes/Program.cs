using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minues = int.Parse(Console.ReadLine()) + 30;
            

            if (minues > 59)
            {
                hours++;
                minues -= 60;
            }
            if (hours > 22)
            {
                
                hours -= 24;
            }
            if (minues < 10)
            {
                Console.WriteLine($"{hours}:0{minues}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minues}");
            }
        }
    }
}
