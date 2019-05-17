using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        

            bool legitStart = int.TryParse(Console.ReadLine(), out int start);
            bool legitEnd = int.TryParse(Console.ReadLine(), out int end);
            
            int sum = 0;

            if (end < start)
            {
                return;
            }

            for (int i = start; i <= end; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            
            Console.WriteLine($"{Environment.NewLine}Sum: {sum}");

            
        }
    }
}
