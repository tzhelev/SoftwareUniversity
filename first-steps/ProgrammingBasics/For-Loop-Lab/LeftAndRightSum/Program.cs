using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= count; i++)
            {
                sum1 += int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= count; i++)
            {
                sum2 += int.Parse(Console.ReadLine());
                }

            
               
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else if(sum2 != sum1)
            {
                int result = sum2 - sum1;
                Console.WriteLine($"No, diff = {Math.Abs(result)}");
            }
          
        }
    }
}
