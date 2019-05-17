using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            if (sex == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else if (age < 16) // Защо тук не става само с else? - защото трябва да няма ()
                {
                    Console.WriteLine("Master");
                }
            }
            if (sex == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
            }
            
        }
    }
}
