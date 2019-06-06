using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sequenceNumber = 0;
            int numberRepeater = 1;
            int differentNumber = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    differentNumber++;
                    if (numberRepeater < differentNumber)
                    {
                        numberRepeater = differentNumber;
                        sequenceNumber = array[i];
                    }
                }
                else
                {
                    differentNumber = 1;
                }
            }

            for (int i = 0; i < numberRepeater; i++)
            {
                Console.Write(sequenceNumber + " ");
            }
        }
    }
}

