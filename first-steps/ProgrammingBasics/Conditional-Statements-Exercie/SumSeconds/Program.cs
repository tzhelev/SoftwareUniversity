using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstContestant = int.Parse(Console.ReadLine()); 
            int secondContestant = int.Parse(Console.ReadLine());
            int thirdContestant = int.Parse(Console.ReadLine());

            double sumOfTime = firstContestant + secondContestant + thirdContestant;

            string result;

            if (sumOfTime < 60 && sumOfTime >= 0)
            {
                if (sumOfTime < 10)
                {
                    result = "0:0" + sumOfTime;
                    Console.WriteLine(result);
                }
                else
                {

                    result = "0:" + sumOfTime;
                    Console.WriteLine(result);
                }
            }
            else if (sumOfTime > 59 && sumOfTime < 120)
            {
                if (sumOfTime > 59 && sumOfTime < 69)
                {
                    sumOfTime = sumOfTime - 60;
                    result = "1:0" + sumOfTime;
                    Console.WriteLine(result);
                }
                else
                {

                    sumOfTime = sumOfTime - 60;
                    result = "1:" + sumOfTime;
                    Console.WriteLine(result);
                }
            }
            else if (sumOfTime > 119 && sumOfTime < 180)
            {
                if (sumOfTime > 119 && sumOfTime < 130)
                {
                    sumOfTime = sumOfTime - 120;
                    result = "2:0" + sumOfTime;
                    Console.WriteLine(result);
                }
                else
                {
                    sumOfTime = sumOfTime - 120;
                    result = "2:" + sumOfTime;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
