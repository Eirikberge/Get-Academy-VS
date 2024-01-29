using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualBasic;

namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var race = new Race();
            var garage = new Garage();
            Console.WriteLine("Velkommen til Eiriks Grand Prix\n");
            Console.WriteLine("Trykk en tast for å starte løp");
            race.AddToRace();
            ConsoleKeyInfo key = Console.ReadKey();
            RaceWithManyCars(race);
        }

        private static void RaceWithManyCars(Race race)
        {
            race.StartingMetod();
            while (race.EndRace())
            {
                race.RaceWithManyCars();
                Thread.Sleep(2000);
            }
            race.PrintPodium();
        }
    }
}