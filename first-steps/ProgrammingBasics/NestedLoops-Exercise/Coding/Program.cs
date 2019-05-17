using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                string number = Console.ReadLine();

                for (int i = number.Length - 1; i >= 0; i--)
                {
                    char symbol = number[i];
                    int numberToSymbol = int.Parse(symbol.ToString());

                    if (numberToSymbol == 0)
                    {
                        Console.WriteLine("ZERO");
                        continue;
                    }
                    for (int j = 1; j <= numberToSymbol; j++)
                    {
                        Console.Write((char)(numberToSymbol + 33));
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}