using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TasksPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> hours = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < hours.Count; i++)
            {
                if (hours[i] < -1 || hours[i] > 5)
                {
                    hours.Remove(hours[i]);
                }
            }
          

            string command = string.Empty;

            int completed = 0;
            int incompleted = 0;
            int dropped = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                List<string> tokens = command.Split(" ").ToList();

                if (tokens[0] == "Complete")
                {
                    int index = int.Parse(tokens[1]);
                    hours[index] = 0;

                }

                if (tokens[0] == "Change")
                {
                    int index = int.Parse(tokens[1]);
                    int time = int.Parse(tokens[2]);

                    if (index < hours.Count && index >= 0)
                    {
                        hours[index] = time;
                    }
                }

                if (tokens[0] == "Drop")
                {
                    int index = int.Parse(tokens[1]);

                    if (index < hours.Count && index >= 0)
                    {
                        hours[index] = -1;
                    }
                }

                if (command.Contains("Count"))
                {
                    if (command.Contains("Completed"))
                    {
                        foreach (var item in hours)
                        {
                            if (item == 0)
                            {
                                completed++;
                            }
                        }
                        Console.WriteLine(completed);
                    }

                    if (command.Contains("Incomplete"))
                    {
                        foreach (var item in hours)
                        {
                            if (item > 0)
                            {
                                incompleted++;
                            }
                        }
                        Console.WriteLine(incompleted);
                    }

                    if (command.Contains("Dropped"))
                    {
                        foreach (var item in hours)
                        {
                            if (item == -1)
                            {
                                dropped++;
                            }
                        }
                        Console.WriteLine(dropped);
                    }
                }

            }

            foreach (var item in hours)
            {
                if (item != 0 && item != -1)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
