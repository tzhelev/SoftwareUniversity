using System;

namespace _01.GiftBoxCoverage
{
    class Program
    {
        static void Main()
        {
            decimal side = decimal.Parse(Console.ReadLine());
            int sheetCount = int.Parse(Console.ReadLine());
            decimal sheetArea = decimal.Parse(Console.ReadLine());

            decimal giftBoxArea = (side * side) * 6;

            int thirdSheet = 0;

            for (int i = 1; i <= sheetCount; i++)
            {
                if (i % 3 == 0)
                {
                    thirdSheet++;
                }
            }

            decimal fullCovaredSheets = sheetCount - thirdSheet;

            decimal porcent = sheetArea * 0.25M;
            decimal allFullSheetsCovarage = fullCovaredSheets * sheetArea;
            decimal thirdSheetCovarage = thirdSheet * porcent;

            decimal allCovarage = allFullSheetsCovarage + thirdSheetCovarage;

            decimal finalCovarage = (allCovarage * 100) / giftBoxArea;

            Console.WriteLine($"You can cover {finalCovarage:f2}% of the box.");

        }
    }
}
