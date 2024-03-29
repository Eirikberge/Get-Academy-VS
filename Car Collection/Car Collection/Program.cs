﻿namespace Car_Collection
{
    class Program
    {
        static void Main()
        {
            Console.WindowHeight = 42;
            var garage = new Garage();
            var cars = garage.GetCars();
            var getInfo = new Sorting(cars);

            while (true)
            {
                var cmd = MenuAndCmd();

                if (cmd == "1") DisplayCountryAndCars(getInfo);
                else if (cmd == "2") DisplayCarAndCountry(getInfo);
                else if (cmd == "3") DisplayCarsByFoundedDate(getInfo);
                else if (cmd == "4") DisplayCarsByAnnualProduction(getInfo);
            }
        }

        private static void DisplayCarsByAnnualProduction(Sorting getInfo)
        {
            getInfo.DisplayCarsByAnnualProduction();
        }

        private static void DisplayCarsByFoundedDate(Sorting getInfo)
        {
            getInfo.DisplayCarsByFoundedDate();
        }

        private static void DisplayCarAndCountry(Sorting getInfo)
        {
            Console.WriteLine("Hvilket bilmerke vil du sjekke?");
            var brandInput = Console.ReadLine();
            getInfo.DisplayCarsCountry(brandInput);
        }

        private static void DisplayCountryAndCars(Sorting getInfo)
        {
            Console.WriteLine("Hvilket land vil du se bilmerkene til? (eller se alle)");
            var countryInput = Console.ReadLine().ToLower();
            if (countryInput == "alle") getInfo.DisplayAllCars();
            else getInfo.DisplayCars(countryInput);
        }

        private static string MenuAndCmd()
        {
            Console.Clear();
            Console.WriteLine("Oversikt over biler:");
            Console.WriteLine();
            Console.WriteLine("Her er en meny over valg:");
            Console.WriteLine("1 = Se hvilke bilmerker et land har");
            Console.WriteLine("2 = Skriv inn bilmerket og se hvilket land det kommer fra");
            Console.WriteLine("3 = Sorter etter når de ble grunnlagt");
            Console.WriteLine("4 = Sorter etter hvor mange biler de produserer årlig");
            Console.WriteLine();

            return Console.ReadLine();
        }
    }
}