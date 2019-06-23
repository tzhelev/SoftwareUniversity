using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main()
        {
            int suggestCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < suggestCount; i++)
            {
                string command = Console.ReadLine();
                List<string> takeGuestName = command.Split().ToList();
                string guestName = takeGuestName[0];

                if (!guests.Contains(guestName) && !command.Contains("not"))
                {
                    guests.Add(guestName);
                    continue;
                }
                else if (guests.Contains(guestName) && !command.Contains("not"))
                {
                    Console.WriteLine($"{guestName} is already in the list!");
                    continue;
                }
                else if (guests.Contains(guestName) && command.Contains("not"))
                {
                    guests.Remove(guestName);
                    continue;
                }
                else if (!guests.Contains(guestName) && command.Contains("not"))
                {
                Console.WriteLine($"{guestName} is not in the list!");
                }
            }

            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
