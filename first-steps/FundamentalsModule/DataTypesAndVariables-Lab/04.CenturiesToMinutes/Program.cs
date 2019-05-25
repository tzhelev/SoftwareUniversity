using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            byte centureis = byte.Parse(Console.ReadLine());
            int yers = centureis * 100;
            double days = yers * 365.2422;
            int hours = (int)days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centureis} centuries = {yers} years = {(int)days} days = {hours} hours = " +
                $"{minutes} minutes");
            
        }
    }
}
    