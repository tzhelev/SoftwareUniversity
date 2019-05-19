using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double startingMoney = currentBalance;
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Game Time")
            {
                string nameOfGame = command;
                bool buyOrNot = false;
               
                switch (nameOfGame)
                {
                    case "OutFall 4":
                        if (currentBalance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            currentBalance -= 39.99;
                            buyOrNot = true;
                            break;
                        }
                        
                    case "CS: OG":
                        if (currentBalance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            currentBalance -= 15.99;
                            buyOrNot = true;
                            break;
                        }
                        
                    case "Zplinter Zell":
                        if (currentBalance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            currentBalance -= 19.99; buyOrNot = true; break;
                        }
                        
                    case "Honored 2":
                        if (currentBalance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            currentBalance -= 59.99; buyOrNot = true; break;
                        }
                        
                    case "RoverWatch":
                        if (currentBalance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            currentBalance -= 29.99; buyOrNot = true; break;
                        }
                        
                    case "RoverWatch Origins Edition":
                        if (currentBalance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            currentBalance -= 39.99; buyOrNot = true; break;
                        }
                        
                    default: Console.WriteLine("Not Found"); break;
                }

                if (buyOrNot)
                {
                    Console.WriteLine($"Bought {nameOfGame}");
                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            double spentMoney = Math.Abs(currentBalance - startingMoney);
            Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
