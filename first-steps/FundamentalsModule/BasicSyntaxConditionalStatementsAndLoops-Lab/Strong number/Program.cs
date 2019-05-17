using System;

namespace Strong_number
{
    class Program
    {
        static void Main()
        {
            
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int sum = 0;

            while (number > 0)
            {
                int factoriel = 1;
                int digit = number % 10;
                number /= 10;

                for (int i = 2; i <= digit; i++)
                {
                    factoriel *= i;
                }

                sum += factoriel;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}



//              int i, number, fact;
//             Console.WriteLine("Enter the Number");
//            number = int.Parse(Console.ReadLine());
//             fact = number;
//            for (i = number - 1; i >= 1; i--)
//            {
//                fact = fact* i;
//            }
//            Console.WriteLine("\nFactorial of Given Number is: "+fact);
//            Console.ReadLine();