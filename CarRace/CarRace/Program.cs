using Microsoft.VisualBasic;

namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Pelle");
            var car2 = new Car("Politibil");
            var car3 = new Car("Brannbil");
            var car4 = new Car("Sam");
            //var cars = new Car[]
            //{
            //    new Car("Pelle"),
            //    new Car("Politibil"),
            //};
            //var car1 = cars[0];
            //var car2 = cars[1];

            var racing = new Racing();

            racing.AddToRace(car2);
            racing.AddToRace(car3);
            racing.AddToRace(car4);

            //SingleRace(car1, race);
            //RaceDouble(car1, car2, race);
            while (racing.EndRace())
            {
                racing.RaceWithManyCars();
            }
            racing.PrintPodium();
        }

        private static void RaceDouble(Car car1, Car car2, Racing race)
        {
            while (car1.Distance < 1000 && car2.Distance < 1000)
            {
                race.DoubleRace(car1, car2);
            }

            Console.WriteLine(race.WinnerText(car1, car2));
            car1.ClearDistance(car1);
            car2.ClearDistance(car2);
            Console.WriteLine();
        }


        private static void SingleRace(Car car1, Racing race)
        {
            while (car1.Distance < 1000)
            {
                race.Drive(car1);
            }
            Console.WriteLine($"{car1.Name} har kjørt {car1.Distance}");
            car1.ClearDistance(car1);
        }
    }
}
//Car race
//Du skal lage en konsollapp med en bil som skal kjøre 1000m.
//Bilen har en start-hastighet på 10m/s ( en iterasjon i en løkke er et sekund).
//Bilen skal øke farten med 10m/s frem til den har kjørt 500m, også skal den
//senke farten med 10m/s igjen frem til den når minimumshastigheten sin på 10m/s.
//Når bilen har kommet seg til slutt-målet printes det ut til skjermen at bilen er
//fremme og har parkert.

//Utvid oppgaven til at du kan lage 2 biler som kjører om kapp i en løkke, der de har en metode som genererer en random
//hastighet til dem mellom 60-200m/s som varer en runde. Det er førstemann til å kjøre 10000m