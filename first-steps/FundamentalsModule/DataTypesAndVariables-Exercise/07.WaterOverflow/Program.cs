using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLoading = int.Parse(Console.ReadLine());
            int currentLitters = 0;
           
            for (int i = 0; i < numberLoading; i++)
            {
                
                int capacity = 255;
                int loadingLitters = int.Parse(Console.ReadLine());
                if (currentLitters + loadingLitters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currentLitters += loadingLitters;
                }
               

            }
            Console.WriteLine(currentLitters);
        }
    }
}
