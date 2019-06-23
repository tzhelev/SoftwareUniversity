using System;

namespace EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());

            double coins = 0.0;

            for (int i = 1; i <= partyDays; i++)
            {
                bool motivationParty = i % 3 == 0;
                bool slayMonster = i % 5 == 0;
                bool tenthDay = i % 10 == 0;
                bool fifteenthDay = i % 15 == 0;

                if (tenthDay)
                {
                    partySize -= 2;
                }

                if (fifteenthDay)
                {
                    partySize += 5;
                }

                coins += 50 - (partySize * 2);

                if (motivationParty)
                {
                    coins -= partySize * 3;
                }

                if (slayMonster)
                {
                    coins += partySize * 20;

                    if (motivationParty)
                    {
                        coins -= partySize * 2;
                    }
                }

            }

            Console.WriteLine($"{partySize} companions received {(int)(coins / partySize)} coins each.");
        }
    }
}