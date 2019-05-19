using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string someWord = Console.ReadLine();
            string reverseWord = string.Empty;
            
            for (int letter = someWord.Length -1; letter >= 0; letter--)
            {
                reverseWord += someWord[letter];
            }

            Console.WriteLine(reverseWord);
        }
    }
}