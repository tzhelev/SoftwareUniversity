using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenRows = int.Parse(Console.ReadLine());
            int[] firstArray = new int[givenRows]; 
            int[] secondArray = new int[givenRows];

            for (int i = 0; i < givenRows; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int k = 0; k < row.Length - 1; k++)
                {
                    if (i % 2 == 0)
                    {
                        firstArray[i] = row[k];
                        secondArray[i] = row[k + 1];
                    }
                    if (i % 2 != 0)
                    {
                        firstArray[i] = row[k + 1];
                        secondArray[i] = row[k];
                    }
                }
            }

            foreach (var item in firstArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
