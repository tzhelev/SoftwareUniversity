using System;
using System.Collections.Generic;
using System.Linq;

namespace LastStop
{
    class Program
    {
        static void Main()
        {
            List<int> listOfPaintings = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                List<string> splitCommand = command.Split().ToList();

                if (command.Contains("Change"))
                {
                    Change(listOfPaintings, splitCommand);
                }

                if (command.Contains("Hide"))
                {
                    int paintingNumber = int.Parse(splitCommand[1]);
                    listOfPaintings.Remove(paintingNumber);
                }

                if (command.Contains("Insert"))
                {
                    Insert(listOfPaintings, splitCommand);
                }

                if (command.Contains("Switch"))
                {
                    Switch(listOfPaintings, splitCommand);
                }

                 if (command.Contains("Reverse"))
                {
                    listOfPaintings.Reverse();
                }
            }

            Console.WriteLine(string.Join(" ", listOfPaintings));
        }

        private static void Switch(List<int> listOfPaintings, List<string> splitCommand)
        {
            int paintingNumber = int.Parse(splitCommand[1]);
            int changedNumber = int.Parse(splitCommand[2]);
            int painingIndex = listOfPaintings.IndexOf(paintingNumber);
            int changedIndex = listOfPaintings.IndexOf(changedNumber);

            if (listOfPaintings.Contains(paintingNumber) &&
                listOfPaintings.Contains(changedNumber))
            {
                listOfPaintings.RemoveAt(changedIndex);
                listOfPaintings.Insert(changedIndex, paintingNumber);
                listOfPaintings.RemoveAt(painingIndex);
                listOfPaintings.Insert(painingIndex, changedNumber);
            }
        }

        private static void Insert(List<int> listOfPaintings, List<string> splitCommand)
        {
            int insertIndex = int.Parse(splitCommand[1]) + 1; // eventually +2
            int paintingNumber = int.Parse(splitCommand[2]);

            if (insertIndex <= listOfPaintings.Count && insertIndex >= 0)
            {
                listOfPaintings.Insert(insertIndex, paintingNumber);
            }
        }

        private static void Change(List<int> listOfPaintings, List<string> splitCommand)
        {
            int paintingNumber = int.Parse(splitCommand[1]);
            int changedNumber = int.Parse(splitCommand[2]);

            if (listOfPaintings.Contains(paintingNumber))
            {
                int painingIndex = listOfPaintings.IndexOf(paintingNumber);
                listOfPaintings.Remove(paintingNumber);
                listOfPaintings.Insert(painingIndex, changedNumber);
            }
        }
    }
}

