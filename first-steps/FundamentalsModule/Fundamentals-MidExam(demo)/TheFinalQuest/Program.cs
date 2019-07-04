using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFinalQuest
{
    class Program
    {
        static void Main()
        {
            List<string> message = Console.ReadLine().Split().ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] separateInput = command.Split();

                if (command.Contains("Delete"))
                {
                    Delete(message, separateInput);
                }

                if (command.Contains("Swap"))
                {
                    Swap(message, separateInput);
                }

                if (command.Contains("Put"))
                {
                    Put(message, separateInput);
                }

                if (command.Contains("Sort"))
                {
                    message.Sort();
                    message.Reverse();
                }

                if (command.Contains("Replace"))
                {
                    Replace(message, separateInput);
                }
            }

            Console.Write(string.Join(" ", message));

        }

        private static void Replace(List<string> message, string[] separateInput)
        {
            string word1 = separateInput[1];
            string word2 = separateInput[2];

            if (message.Contains(word2))
            {
                int index = message.IndexOf(word2);

                message.RemoveAt(index);
                message.Insert(index, word1);
            }
        }

        private static void Put(List<string> message, string[] separateInput)
        {
            string word = separateInput[1];
            int index = int.Parse(separateInput[2]);

            if (index < message.Count && index >= 0)
            {
                message.Insert(index - 1, word);
            }
            else
            {
                message.Add(word);
            }
        }

        private static void Swap(List<string> message, string[] separateInput)
        {
            string word1 = separateInput[1];
            string word2 = separateInput[2];

            if (message.Contains(word1) && message.Contains(word2))
            {
                int indexWord1 = message.IndexOf(word1);
                int indexWord2 = message.IndexOf(word2);

                message.RemoveAt(indexWord1);
                message.Insert(indexWord1, word2);
                message.RemoveAt(indexWord2);
                message.Insert(indexWord2, word1);
            }
        }

        private static void Delete(List<string> message, string[] separateInput)
        {
            int index = int.Parse(separateInput[1]);
            if (index < message.Count-1 && index >= 0)
            {
                message.RemoveAt(index+1);
            }
        }
    }
}
