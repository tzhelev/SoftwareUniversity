using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = double.Parse(Console.ReadLine());

            while ( 5.49 < result && 6.00 >= result)
            {
                Console.WriteLine("Excellent!");
                break;
            }
        }
    }
}
