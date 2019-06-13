using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int sum = Sum(n1, n2);
            int result = Subtract(sum, n3);

            Console.WriteLine(result);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
