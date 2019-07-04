using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FroggySquad
{
    class Program
    {
        static void Main()
        {
            List<string> frogs = Console.ReadLine().Split().ToList();



            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command.Contains("Join"))
                {
                    string frogName = command[1];

                    if (!frogs.Contains(frogName))
                    {
                        frogs.Add(frogName);
                    }
                }

                if (command.Contains("Jump"))
                {
                    string frogName = command[1];
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index < frogs.Count)
                    {
                        frogs.Insert(index, frogName);
                    }
                }

                if (command.Contains("Dive"))
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < frogs.Count)
                    {
                        frogs.RemoveAt(index);
                    }
                }

                if (command.Contains("First"))
                {
                    int count = int.Parse(command[1]);

                    if (count > frogs.Count)
                    {
                        for (int i = 0; i < frogs.Count; i++)
                        {
                            Console.Write(frogs[i] + " ");
                        }
                        Console.WriteLine();
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(frogs[i] + " ");
                    }
                    Console.WriteLine();
                }

                if (command.Contains("Last"))
                {
                    int count = int.Parse(command[1]);
                    frogs.Reverse();

                    if (count > frogs.Count)
                    {

                        for (int j = count - 1; j >= 0; j--)
                        {
                            Console.Write(frogs[j] + " ");
                        }
                        frogs.Reverse();
                        continue;
                        
                    }


                    for (int j = count - 1; j >= 0; j--)
                    {
                        Console.Write(frogs[j] + " ");
                    }
                    frogs.Reverse();



                }

                if (command.Contains("Print"))
                {
                    if (command[1] == "Normal")
                    {
                        Console.Write("Frogs: ");
                        Console.WriteLine(string.Join(" ", frogs));
                        return;
                    }

                    if (command[1] == "Reversed")
                    {
                        frogs.Reverse();

                        Console.Write("Frogs: ");
                        Console.WriteLine(string.Join(" ", frogs));
                        return;
                    }
                }
            }

        }
    }
}
