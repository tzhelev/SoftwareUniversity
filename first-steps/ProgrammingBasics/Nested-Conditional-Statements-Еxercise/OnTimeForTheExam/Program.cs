using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            if (examHour < arrivalHour)
            {

            }
            else if (examHour >= arrivalHour)
            {
                if (examHour == arrivalHour && (arrivalMinute - examMinute) < 0)
                {

                }
                else if (true)
                {

                }
            }
        }
    }
}
