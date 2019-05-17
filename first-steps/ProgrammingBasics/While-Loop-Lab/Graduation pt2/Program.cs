using System;

namespace Graduation_pt2
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
            int secondTry = 0;
            int excludedClass = 0;

            while (count < 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                
                double state = currentGrade;

                if (currentGrade >= 4.00)
                {
                    yearGrade += currentGrade;
                    count++;
                }
                if (state < 4.00) 
                {
                    secondTry++;
                    lessThenFourFirst = true;
                    
                }
                if (lessThenFourFirst && secondTry > 1)
                {
                    lessThenFourSecond = true;
                }
                if (lessThenFourSecond)
                {
                    excludedClass = ++count;
                    Console.WriteLine($"{studentName} has been excluded at {excludedClass} grade");
                    break;
                }
            }

            double finalGrade = yearGrade / 12;

            if (finalGrade >= 4.00 && count == 12)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {finalGrade:f2} ");
            }
        }
    }
}
