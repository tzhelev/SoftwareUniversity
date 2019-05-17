using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int allPieces = a * b;
            int numberTakenPieces = 0;

            while (numberTakenPieces < allPieces && command != "STOP")
            {
                int takePieces = int.Parse(command);
                numberTakenPieces += takePieces;

                if (numberTakenPieces >= allPieces)
                {
                    continue;
                }
                command = Console.ReadLine();
            }

            int diff = allPieces - numberTakenPieces;

            if (diff >= 0 && command == "STOP")
            {
                Console.WriteLine($"{diff} pieces are left.");
            }
            else if (diff < 0)
            {
                diff = Math.Abs(diff);
                Console.WriteLine($"No more cake left! You need {diff} pieces more.");
            }
        }
    }
}
