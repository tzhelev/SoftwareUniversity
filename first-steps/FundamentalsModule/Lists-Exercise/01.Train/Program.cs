using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains("Add"))
                {
                    List<string> addPassangers = command.Split(" ").ToList();
                    int addWagon = int.Parse(addPassangers[1]);
                    train.Add(addWagon);
                    continue;
                }

                int addPeople = int.Parse(command);

                if (addPeople > maxCapacity)
                {
                    continue;
                }

                for (int i = 0; i < train.Count; i++)
                {
                    if (train[i] + addPeople <= maxCapacity)
                    {
                        train[i] += addPeople;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", train));

        }
    }
}
