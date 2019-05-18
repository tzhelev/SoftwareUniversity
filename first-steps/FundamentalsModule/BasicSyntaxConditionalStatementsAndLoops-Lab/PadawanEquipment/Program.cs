using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceForEachLightsaber = double.Parse(Console.ReadLine());
            double priceForEachRobe = double.Parse(Console.ReadLine());
            double priceForEachBelt = double.Parse(Console.ReadLine());

            int freeBelts = 0;
            for (int freeBelt = 6; freeBelt <= countOfStudents; freeBelt += 6)
            {
                freeBelts++;
            }

            double priceForAllRobes = priceForEachRobe * countOfStudents;
            double priceForAllBelts =  priceForEachBelt * (countOfStudents - freeBelts);
            double priceForAllLightsaber = priceForEachLightsaber * Math.Ceiling((countOfStudents * 1.10));

            double finalPrice = priceForAllBelts + priceForAllLightsaber + priceForAllRobes;

            double diff = Math.Abs(finalPrice - availableMoney);

            if (finalPrice <= availableMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {diff:f2}lv more.");
            }
        }
    }
}
