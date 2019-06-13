using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main()
        {
            string someString = Console.ReadLine();

            TakeMiddleChar(someString);
        }

        static void TakeMiddleChar(string someString)
        {
            if (someString.Length % 2 == 0)
            {
                string result = someString[someString.Length / 2 -1] +
                    "" + someString[someString.Length / 2];
                Console.WriteLine(result);
            }
            else
            {
                char result = someString[someString.Length / 2];
                Console.WriteLine(result);
            }
        }
    }
}
