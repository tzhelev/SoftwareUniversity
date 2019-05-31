using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays =
            {
                "Monday",
                "Tueday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int choseDay = (int.Parse(Console.ReadLine()) - 1);
            if (choseDay >= 0 && choseDay<=6)
            {
                Console.WriteLine(weekDays[choseDay]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
              
           
        }
    }
}
