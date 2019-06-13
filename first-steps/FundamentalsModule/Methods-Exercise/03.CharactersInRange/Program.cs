using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char lastChar = char.Parse(Console.ReadLine());
            PrintCharsBetween(firstChar, lastChar);
        }

        static void PrintCharsBetween(char firstChar, char lastChar)
        {
            if (lastChar < firstChar)
            {
                char exchange;
                exchange = firstChar;
                firstChar = lastChar;
                lastChar = exchange;
            }
            for (int i = firstChar + 1;  i < lastChar;  i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
