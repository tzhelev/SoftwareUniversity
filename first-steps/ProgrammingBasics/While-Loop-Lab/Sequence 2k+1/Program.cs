using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int kat = 1;

            while (kat <= n)
            {
                Console.WriteLine(kat);
                kat = (2 * kat) + 1;
            } 
        }
    }
}
