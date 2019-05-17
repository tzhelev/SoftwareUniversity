using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFloor = int.Parse(Console.ReadLine());
            int countRoom = int.Parse(Console.ReadLine());

            for (int floor = countFloor; floor >= 1; floor--)
            {

                for (int room = 0; room < countRoom; room++)
                {
                    if (floor == countFloor)
                    {
                        Console.Write($"L{floor}{room} ");
                        
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else if(floor % 2 != 0)
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
