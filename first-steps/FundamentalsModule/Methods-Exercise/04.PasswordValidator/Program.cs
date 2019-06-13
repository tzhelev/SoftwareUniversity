using System;
using System.Text.RegularExpressions;

namespace _04.PasswordValidator
{
    class Program
    {
       static bool Length = false;
       static bool Symbols = false;
       static bool CountOfDigits = false;


        static void Main()
        {
            string password = Console.ReadLine();

            CheckLength(password);
            CheckSymbols(password);
            CheckCountOfDigits(password);

            if (Length && Symbols && CountOfDigits)
            {
                Console.WriteLine("Password is valid");
            }
           
        }

        static void CheckLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                Length = true;
            }
        }

        static void CheckSymbols(string password)
        {
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            else
            {
                Symbols = true;
            }
        }

        static void CheckCountOfDigits(string password)
        {
            int digitCount = 0;

            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitCount++;
                }
            }
            if (digitCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                CountOfDigits = true;
            }

        }
    }
}
