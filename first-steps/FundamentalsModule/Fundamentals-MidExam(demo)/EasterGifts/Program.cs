using System;

namespace EasterGifts
{
    class Program
    {
        static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            int coins = 0;

            for (int curentDay = 1; curentDay <= partyDays; curentDay++)
            {
                coins += 50 - (partySize * 2);
                bool motivationParty = curentDay % 3 == 0;
                bool slayMonster = curentDay % 5 == 0;
                bool tenthDay = curentDay % 10 == 0;
                bool fifteenthDay = curentDay % 15 == 0;

                if (tenthDay)
                {
                    partySize -= 2;
                }

                if (fifteenthDay)
                {
                    partySize += 5;
                }

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

            Console.WriteLine($"{partySize} companions received {coins / partySize} coins each.");
        }
    }
}
