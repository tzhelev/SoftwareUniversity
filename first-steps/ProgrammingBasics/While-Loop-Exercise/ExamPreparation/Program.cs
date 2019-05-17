using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {

            int badGrades = int.Parse(Console.ReadLine());
            string nameOfProblem = Console.ReadLine();
            int countBadGrades = 0;
            int sumGrades = 0;
            int countProblems = 0;
            string lastProblem = string.Empty;
            bool badGrade = false;

            while (nameOfProblem != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                countProblems++;

                if (grade <= 4)
                {
                    countBadGrades++;

                    if (countBadGrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {countBadGrades} poor grades.");
                        badGrade = true;
                        break;
                    }
                }

                lastProblem = nameOfProblem;
                nameOfProblem = Console.ReadLine();
            }


            if (badGrade == false)
            {
                double average = sumGrades * 1.0 / countProblems;
                Console.WriteLine($"Average score: {average:F2}");
                Console.WriteLine($"Number of problems: {countProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
    
}
