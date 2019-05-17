using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSteps = int.Parse(Console.ReadLine());
            int countOfDancers = int.Parse(Console.ReadLine());
            int countOfDays = int.Parse(Console.ReadLine());

            double porcentForEachDancers = (double)(countOfSteps / countOfDays) / countOfSteps * 100;
            porcentForEachDancers = Math.Ceiling(porcentForEachDancers);

            double porcentForOneDay = porcentForEachDancers / countOfDancers;
           
          
            if (porcentForEachDancers <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {porcentForOneDay:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {porcentForOneDay:f2}% steps to be learned per day.");
            }
        }
    }
}
