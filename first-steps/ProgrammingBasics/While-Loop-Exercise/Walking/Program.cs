using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string command = string.Empty;
            int allSteps = 0;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    allSteps += stepsToHome;
                    break;
                }

                int steps = int.Parse(command);
                allSteps += steps;

                if (allSteps >= 10000)
                {
                    break;
                }
            }
            if (allSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                int diffSteps = 10000 - allSteps;
                Console.WriteLine($"{diffSteps} more steps to reach goal.");
            }
        }
    }
}
