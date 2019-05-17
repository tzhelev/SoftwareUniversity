using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Reverse(user);
            int incorrectPass = 0;

            while (Console.ReadLine() != pass)
            {
                
                incorrectPass++;
                if (incorrectPass == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            Console.WriteLine($"User {user} logged in.");
            
        }



        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
