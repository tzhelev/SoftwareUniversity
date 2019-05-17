using System;

namespace InvalidNumer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            bool condition = num > 201 && num < 99 && num != 0;

            if (condition)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
h