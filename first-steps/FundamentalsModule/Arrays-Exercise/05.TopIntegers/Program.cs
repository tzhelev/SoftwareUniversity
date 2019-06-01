using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isTopInt = true;

                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] <= array[k])
                    {   
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.Write(array[array.Length - 1]);
        }
    }
}
