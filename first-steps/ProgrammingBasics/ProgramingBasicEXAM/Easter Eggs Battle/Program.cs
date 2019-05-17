using System;

namespace Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerOneEggs = int.Parse(Console.ReadLine());
            int playerTwoEggs = int.Parse(Console.ReadLine());
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End of battle")
            {
                if (command == "one")
                {
                    playerTwoEggs--;
                }
                else if(command == "two")
                {
                    playerOneEggs--;
                }
                if (playerOneEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwoEggs} eggs left.");
                    return;
                }
                else if (playerTwoEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playerOneEggs} eggs left.");
                    return;
                }
            }

            Console.WriteLine($"Player one has {playerOneEggs} eggs left.");
            Console.WriteLine($"Player two has {playerTwoEggs} eggs left.");
        }
    }
}
