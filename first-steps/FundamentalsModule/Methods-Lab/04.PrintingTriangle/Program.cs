using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 1; col < n + 1; col++)
            {
                PrintLine(col);
            }

            for (int col = n - 1; col >= 0; col--)
            {
                PrintLine(col);
            }
        }

        static void PrintLine(int col)
        {
            for (int row = 1; row <= col; row++)
            {
                Console.Write(row + " ");
            }
            
            Console.WriteLine();
        }
    }
}
