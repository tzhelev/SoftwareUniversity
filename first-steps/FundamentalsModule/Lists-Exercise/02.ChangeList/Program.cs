using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string breakLoop = string.Empty;

            while ((breakLoop = Console.ReadLine()) != "end")
            {
                if (breakLoop.Contains("Delete"))
                {
                    RemoveElement(numbers, breakLoop);
                }
                else
                {
                    AddElement(numbers, breakLoop);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void AddElement(List<int> numbers, string breakLoop)
        {
            List<string> positionAndElement = breakLoop.Split().ToList();
            int.TryParse(positionAndElement[1], out int element);
            int.TryParse(positionAndElement[2], out int position);
            numbers.Insert(position, element);
        }

        private static void RemoveElement(List<int> numbers, string breakLoop)
        {
            List<string> separatedComand = breakLoop.Split().ToList();
            int.TryParse(separatedComand[1], out int element);

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Remove(element);
            }
        }
    }
}
