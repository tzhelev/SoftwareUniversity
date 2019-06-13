using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main()
        {
            string someString = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());
            string concatenatedString = ConcatenateString(someString, repeatCount);
            Console.WriteLine(concatenatedString);
        }

        static string ConcatenateString(string text, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += text;
            }
            return result;
        } 
    }
}
