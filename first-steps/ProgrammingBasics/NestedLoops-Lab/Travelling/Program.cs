using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double neededMoney = double.Parse(Console.ReadLine());
            double savedMoney = 0;
           

            while (destination != "End")
            {
                double savingMoney = double.Parse(Console.ReadLine());
                if (neededMoney > savedMoney)
                {
                    savedMoney += savingMoney;
                }
                if (savedMoney >= neededMoney)
                {
                    Console.WriteLine($"Going to {destination}!");
                    savedMoney = 0;
                }
                if (savedMoney == 0)
                {
                    destination = Console.ReadLine();
                    if (destination != "End")
                    {
                        neededMoney = double.Parse(Console.ReadLine());
                        
                    }
                  
                }
            }
        }
    }
}
