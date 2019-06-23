﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyProfit
{
    class Program
    {
        static void Main()
        {
            List<string> giftList = Console.ReadLine().Split().ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "No Money")
            {
                List<string> separatedCommand = command.Split().ToList();

                if (command.Contains("OutOfStock"))
                {
                    OutOfStock(giftList, separatedCommand);
                }

                if (command.Contains("Required"))
                {
                    Required(giftList, separatedCommand);
                }

                if (command.Contains("JustInCase"))
                {
                    giftList.RemoveAt(giftList.Count - 1);
                    giftList.Add(separatedCommand[1]);
                }
            }

            for (int i = 0; i < giftList.Count; i++)
            {
                if (giftList[i] == "None")
                {
                    giftList.Remove(giftList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", giftList));
        }

        private static void Required(List<string> giftList, List<string> separatedCommand)
        {
            int.TryParse(separatedCommand[2], out int index);

            if (index < giftList.Count - 1 && index >= 0)
            {
                giftList.RemoveAt(index);
                giftList.Insert(index, separatedCommand[1]);
            }
        }

        private static void OutOfStock(List<string> giftList, List<string> separatedCommand)
        {
            for (int i = 0; i < giftList.Count; i++)
            {
                if (giftList.Contains(separatedCommand[1]))
                {
                    giftList[giftList.FindIndex(ind => ind.Equals(separatedCommand[1]))]
                        = "None";
                }
            }
        }
    }
}
