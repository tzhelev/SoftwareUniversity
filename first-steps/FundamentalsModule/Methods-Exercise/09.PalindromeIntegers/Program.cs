using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = string.Empty;

            while ((someString = Console.ReadLine()) != "END")
            {
                FindPolindrome(someString);
            }
        }

        private static void FindPolindrome(string someString)
        {

            if (someString.Contains("-"))
            {
                return;
            }
            string reverseCommand = string.Empty;

            for (int i = someString.Length - 1; i >= 0; i--)
            {
                reverseCommand += someString[i];
            }

            if (someString == reverseCommand)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
