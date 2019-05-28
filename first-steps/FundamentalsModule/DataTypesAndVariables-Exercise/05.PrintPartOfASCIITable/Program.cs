using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSymbol = int.Parse(Console.ReadLine());
            int lastSymbol = int.Parse(Console.ReadLine());

            for (int i = firstSymbol; i <= lastSymbol; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
