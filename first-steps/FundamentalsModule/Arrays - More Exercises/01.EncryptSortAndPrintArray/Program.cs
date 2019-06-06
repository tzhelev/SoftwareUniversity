using System;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main()
        {
            int loop = int.Parse(Console.ReadLine());
            
            int[] result = new int[loop];
            

            for (int i = 0; i < loop; i++)
            {
                int totalSum = 0; 
                string word = Console.ReadLine();
                for (int j = 0; j < word.Length; j++)
                {
                    int sumOfConsonant = 0;
                    int sumOfVowel = 0;
                   
                    bool isVowel = word[j] == 'a' || word[j] == 'e' || word[j] == 'i' || word[j] == 'o' || word[j] == 'u' ||
                        word[j] == 'A' || word[j] == 'E' || word[j] == 'I' || word[j] == 'O' || word[j] == 'U';
                   
                    if (isVowel)
                    {
                        sumOfVowel += word[j] * word.Length;
                    }
                    else
                    {
                        sumOfConsonant += word[j] / word.Length;

                    }
                    totalSum += sumOfConsonant + sumOfVowel;
                    result[i] = totalSum;
                }
            }

            Array.Sort(result);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
