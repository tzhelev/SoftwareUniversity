using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double n = double.Parse(Console.ReadLine());
            int count = 0;
            int maxValue = int.MinValue;

            while (count < n)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > maxValue)
                {
                    maxValue = currentNum;
                }

                count++;
            }
            Console.WriteLine(maxValue);
            
        }
    }
}
