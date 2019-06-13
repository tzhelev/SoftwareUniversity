using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main()
        {
            //'a', 'e', 'i', 'o', 'u',
            string someString = Console.ReadLine();
            CountVowels(someString);

        }

        static void CountVowels(string someString)
        {
            string word = someString;
            int vowelCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char symbol = word[i];

                if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' ||
                    symbol == 'A' || symbol == 'E' || symbol == 'I' || symbol == 'O' || symbol == 'U')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);
        }
    }
}
