using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfBook = Console.ReadLine();
            int library = int.Parse(Console.ReadLine());

            int count = 0;
            string libraryBook = "";

            while (nameOfBook != libraryBook &&  count < library)
            {
                
                libraryBook = Console.ReadLine();
                count++;
            }
            if (nameOfBook != libraryBook && count == library)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
            if (nameOfBook == libraryBook)
            {
                --count;
                Console.WriteLine($"You checked {count} books and found it.");
            }
        }
    }
}
