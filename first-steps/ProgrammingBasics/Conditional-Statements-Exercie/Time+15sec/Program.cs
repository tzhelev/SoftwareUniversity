using System;

namespace Time_15sec
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMin = int.Parse(Console.ReadLine());

            int timeInMin = startHour * 60 + startMin;
            timeInMin = timeInMin + 15;

            int finalHour = timeInMin / 60;
            int finalMin = timeInMin % 60;

            if (finalHour > 23)
            {
                finalHour -= 24;
            }
            if (finalMin < 10)
            {
                Console.WriteLine($"{finalHour}:0{finalMin}");
            }
            else
            {
                Console.WriteLine($"{finalHour}:{finalMin}");
            }
        }
    }
}
