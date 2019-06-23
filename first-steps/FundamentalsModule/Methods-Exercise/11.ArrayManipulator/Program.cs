using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains("exchange"))
                {

                }

                if (command.Contains("max odd"))
                {

                }

                if (command.Contains("max even"))
                {

                }

                if (command.Contains("min odd"))
                {

                }

                if (command.Contains("min even"))
                {

                }
            }

            Console.WriteLine(string.Join(",", initialArray));
        }
    }
}

