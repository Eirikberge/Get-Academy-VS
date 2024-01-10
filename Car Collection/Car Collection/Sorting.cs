using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Car_Collection
{
    internal class Sorting
    {
        private Car[] _cars;
        public Sorting(Car[] cars)
        {
            _cars = cars;
        }

        public void DisplayAllCars()
        {
            Headliner("Land:");
            foreach (var car in _cars)
            {
                Console.WriteLine(car.Brand.PadRight(16) + car.Country);
            }
            Console.ReadLine();
        }

        public void DisplayCars(string countryInput)
        {
            var foundCar = false;
            var formattedCountryInput = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(countryInput);
            foreach (var car in _cars)
            {
                if (formattedCountryInput == car.Country)
                {
                    Console.WriteLine($" - {car.Brand}");
                    foundCar = true;
                }
            }

            if (!foundCar) Console.WriteLine($"Ingen land matcher med {countryInput}. Trykk på en knapp for å prøve å på nytt");

            Console.ReadLine();
        }

        public void DisplayCarsCountry(string brandInput)
        {
            Console.WriteLine($"Du søkte etter: {brandInput}");
            Console.WriteLine();
            var foundCar = false;
            var formatedBrandInput = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(brandInput);
            foreach (var car in _cars)
            {
                if (formatedBrandInput == car.Brand)
                {
                    Console.WriteLine($"Bilmerket {car.Brand} er fra {car.Country}");
                    foundCar = true;
                }
            }

            if (!foundCar) Console.WriteLine($"Ingen bilmerker matcher med {brandInput}. Trykk på en knapp for å prøve å på nytt");

            Console.ReadLine();
        }

        public void DisplayCarsByFoundedDate()
        {
            Headliner("Grunnlagt:");

            Array.Sort(_cars, (x, y) => x.FoundedYear.CompareTo(y.FoundedYear));
            foreach (var car in _cars)
            {
                Console.WriteLine(car.Brand.PadRight(16) + car.FoundedYear);
            }
            Console.ReadLine();
        }

        public void DisplayCarsByAnnualProduction()
        {
            Headliner("Årlig Produksjon:");

            Array.Sort(_cars, (x, y) => x.AnnualProduction.CompareTo((y.AnnualProduction)));
            foreach (var car in _cars)
            {
                string formattedProduction = car.AnnualProduction.ToString("N0");
                Console.WriteLine(car.Brand.PadRight(16) + formattedProduction);
            }
            Console.ReadLine();
        }
        private static void Headliner(string label)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bilmerke:".PadRight(16) + label);
            Console.ResetColor();
        }
    }
    //Merk at når du gjør Array.Sort, så endrer du arrayen. Det er ikke noe problem her, men kan være det i andre sammenhenger.
}
