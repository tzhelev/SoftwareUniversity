using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main()
        {
            int matrixNumber = int.Parse(Console.ReadLine());

            PrintMatrix(matrixNumber);
        }

        private static void PrintMatrix(int colAndRow)
        {
            for (int col = 0; col < colAndRow; col++)
            {
                for (int row = 0; row < colAndRow; row++)
                {
                    Console.Write(colAndRow + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
