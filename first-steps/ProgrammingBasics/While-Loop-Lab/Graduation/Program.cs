using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int count = 0;
            double yearGrade = 0.0;


            while (count < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.0)
                {
                    yearGrade += grade;
                    count++;
                }
            }

            double finalGrade = yearGrade / 12;

            if (finalGrade >= 4.00)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {finalGrade:f2} ");
            }
            
        }
    }
}
