using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryStrings = Console.ReadLine().Split().ToArray();

            for (int i = entryStrings.Length -1; i >=0; i--)
            {
                Console.Write($"{entryStrings[i]} ");
            }
        }
    }
}
