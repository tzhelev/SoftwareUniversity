using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfPoorGrades = int.Parse(Console.ReadLine());
            string nameOfProblem = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());

            
            int countOfBadGrades = 0;
            int sumOfGrade = 0;
            int count = 0;
            
            

            while (nameOfProblem != "Enough" && countOfBadGrades < 2)
            {
                if (grade <= 3)
                {
                    countOfBadGrades++;
                    sumOfGrade += grade;
                    nameOfProblem = Console.ReadLine();
                    grade = int.Parse(Console.ReadLine());
                }
                else
                {
                    sumOfGrade += grade;
                    count++;
                    nameOfProblem = Console.ReadLine();
                    if (nameOfProblem != "Enough" && countOfBadGrades > 2)
                    {
                        grade = int.Parse(Console.ReadLine());
                    }
                    
                }
                
            }
            double finalGrade =(double) sumOfGrade / count;

            if (countOfBadGrades >= 2)
            {
                Console.WriteLine($"You need a break, {countOfBadGrades} poor grades.");
            }

            if (nameOfProblem == "Enough")
            {
                Console.WriteLine($"Average score: {finalGrade}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {nameOfProblem}");
            }
        }
    }
}
