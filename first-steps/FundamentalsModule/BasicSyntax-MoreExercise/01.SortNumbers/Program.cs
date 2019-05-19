using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int maxNumber = 0, midNumber = 0, minNumber = 0;


            if (n1 <= n2 && n1 <= n3)
            {
                minNumber = n1;
            }
            if (n2 <= n1 && n2 <= n3)
            {
                minNumber = n2;
            }
            if (n3 <= n2 && n3 <= n1)
            {
                minNumber = n3;
            }

            if (n1 >= n2 && n1 >= n3)
            {
                maxNumber = n1;
            }
            if (n2 >= n1 && n2 >= n3)
            {
                maxNumber = n2;
            }
            if (n3 >= n1 && n3 >= n2)
            {
                maxNumber = n3;
            }

            if ((maxNumber == n1 || minNumber == n1) && (maxNumber == n2 || minNumber == n2))
            {
                midNumber = n3;
            }
            if ((maxNumber == n2 || minNumber == n2) && (maxNumber == n3 || minNumber == n3))
            {
                midNumber = n1;
            }
            if ((maxNumber == n1 || minNumber == n1) && (maxNumber == n3 || minNumber == n3))
            {
                midNumber = n2;
            }

            Console.WriteLine($"{maxNumber}\n{midNumber}\n{minNumber}");
        }
    }
}
