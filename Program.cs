using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> clubs = new MyDictonary<int, string>();

            clubs.Add(01, "Barcelona");
            clubs.Add(02, "Real Madrid");
            clubs.Add(03, "Mallorca");
            clubs.Add(04, "İnter");
            clubs.Add(05, "Milan");
            clubs.Add(06, "Juventus");
            clubs.Add(07, "Atletico Madrid");
            clubs.Add(08, "Roma");

            foreach (var club in clubs.Values)
            {
                Console.WriteLine(club);
            }
            foreach (var numbers in clubs.Keys)
            {
                Console.WriteLine(numbers);
            }

            Console.ReadLine();
        }
    }
}
