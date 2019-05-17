using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBigger = false;
            int current = 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write($"{current} ");
                    current++;
                    
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
