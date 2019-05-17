using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int count = 0;
            double yearGrade = 0.0;

            bool lessThenFourFirst = false;
            bool lessThenFourSecond = false;
            int excludedClass = 0;

            while (count < 12)
            {
                if (yearGrade < 4.00)
                {
                    lessThenFourFirst = true;

                }
                if (lessThenFourFirst)
                {
                    lessThenFourSecond = true;
                }

                yearGrade += double.Parse(Console.ReadLine());
                count++;
                if (lessThenFourSecond)
                {
                    excludedClass = count;
                }
            }

            double finalGrade = yearGrade / 12;

            if (finalGrade >= 4.00)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {finalGrade:f2} ");
            }
            else if (lessThenFourSecond)
            {
                Console.WriteLine($"{studentName} has been excluded at {excludedClass} grade");
            }
        }
    }
}
