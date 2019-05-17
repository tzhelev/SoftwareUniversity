using System;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool flour = false;
            bool eggs = false;
            bool sugar = false;

            for (int i = 1; i <= n; i++)
            {
                string product = string.Empty;


                while (product != "Bake!")
                {
                    product = Console.ReadLine();

                    if (product == "flour")
                    {
                        flour = true;
                    }
                    else if (product == "eggs")
                    {
                        eggs = true;
                    }
                    else if (product == "sugar")
                    {
                        sugar = true;
                    }
                }
                if (product == "Bake!")
                {
                    if (flour && eggs && sugar)
                    {
                        Console.WriteLine($"Baking batch number {i}...");
                        flour = false;
                        eggs = false;
                        sugar = false;
                    }
                    else
                    {
                        Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                        i--;
                    }
                }
            }

        }
    }
}
