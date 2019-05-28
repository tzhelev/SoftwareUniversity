using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int sumNumber = int.Parse(Console.ReadLine());
            int devidedNumber = int.Parse(Console.ReadLine());
            int multiplyNumber = int.Parse(Console.ReadLine());

            int result = ((firstNumber + sumNumber) / devidedNumber) * multiplyNumber;

            Console.WriteLine(result);

        }
    }
}
