using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation % array.Length; i++)
            {
                int firstIndex = array[0];

                for (int k = 0; k < array.Length - 1; k++)
                {
                    array[k] = array[k + 1];
                }
                array[array.Length - 1] = firstIndex;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
