using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = 0;

            int brokenKeyboard = 0;
            


            for (int i = 1; i <= lostGames; i++)
            {
                bool brokenHeadset = false;
                bool brokenMouse = false;

                if (i % 2 == 0)
                {
                    expenses += headsetPrice;
                    brokenHeadset = true;
                }
                if (i % 3 == 0)
                {
                    expenses += mousePrice;
                    brokenMouse = true;
                }
                if (brokenHeadset && brokenMouse)
                {
                    expenses += keyboardPrice;
                    brokenKeyboard++;
                }
                if (brokenKeyboard == 2)
                {
                    expenses += displayPrice;
                    brokenKeyboard = 0;
                }
            }

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}

//1
//2    2 h
//3    3 m
//4    2 h     
//5
//6     3m 2h