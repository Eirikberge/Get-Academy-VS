using System.Diagnostics.Metrics;

namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new Car[]
            {
                new Car("Pelle"),
                new Car("Politibil"),
            };
            var car1 = cars[0];
            var car2 = cars[1];

            while (car1.Distance <= 10000 || car2.Distance <= 10000)
            {
                car1.Race(car2);
                Console.WriteLine($"{car1.Name} har kjørt {car1.Distance}");
                Console.WriteLine($"{car2.Name} har kjørt {car2.Distance}");
                Console.WriteLine("");
            }
            if (car1.Distance > car2.Distance)
            {
                Console.WriteLine($"{car1.Name} kom først i mål");
            }
            else Console.WriteLine($"{car2.Name} kom først i mål");
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