using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] train = new int[arrayLength];
            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }

            foreach (var item in train)
            {
                Console.Write(item + " ");
                
            }
            Console.WriteLine($"\n{sum}");
        }
    }
}
