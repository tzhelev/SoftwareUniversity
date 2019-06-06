using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main()
        {

            //UNSOLVED!!!
            int lengthOfDNA = int.Parse(Console.ReadLine());
            int[] dnaSequence = new int[lengthOfDNA];
            string command = string.Empty;
            int maxSumOfDna = 0;
            int currentSequence = 0;
            int indexOfBestSequence = 0;
            int[] bestSequenceToPrint = new int[lengthOfDNA];

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                currentSequence++;
                dnaSequence = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int sumOfDna = 0;
                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    sumOfDna += dnaSequence[i];

                    if (sumOfDna > maxSumOfDna)
                    {
                        maxSumOfDna = sumOfDna;
                        indexOfBestSequence = currentSequence;
                        bestSequenceToPrint = dnaSequence;
                    }
                }

                int bestSequence = 1;
                for (int i = 1; i < dnaSequence.Length; i++)
                {
                    if (dnaSequence[i] == dnaSequence[i - 1])
                    {
                        bestSequence++;
                        indexOfBestSequence = currentSequence;
                        bestSequenceToPrint = dnaSequence;
                    }
                    else
                    {
                        bestSequence = 1;
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {indexOfBestSequence} with sum: {maxSumOfDna}.");
        }
    }
}
