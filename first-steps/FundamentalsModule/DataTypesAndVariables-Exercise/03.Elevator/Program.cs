using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            double fullCourses = Math.Ceiling((double)numberOfPersons / capacityElevator);

            
                Console.WriteLine(fullCourses);
          
        }
    }
}
