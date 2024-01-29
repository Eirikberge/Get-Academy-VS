using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace CarRace
{
    internal class Race
    {
        private List<Car> _racingCars = new List<Car>();
        private Random random = new Random();
        private int _laps = 0;
        private Garage _garage = new Garage();
        private Car _car;
        public int RaceDistance { get; private set; } = 1000;

        public void AddToRace()
        {
            foreach (var car in _garage.GetCarsInGarage())
            {
                _racingCars.Add(car);
            }
        }

        public void RaceWithManyCars()
        {
            foreach (var car in _racingCars)
            {
                car.ChangeSpeed(car, random.Next(60, 200));
                car.ChangeDistance(car);
                //Console.WriteLine($"{car.Name.PadRight(15)} - {car.Distance}".PadLeft(20));
            }

            var carOrder = _racingCars.OrderByDescending(car => car.Distance).ToList();
            Console.WriteLine
                ($"{carOrder[0].Name} leder foran {carOrder[1].Name}" +
                 $" med {carOrder[0].Distance - carOrder[1].Distance} meter" +
                 $" etter {++_laps} {(_laps==1 ? "runde" : "runder")} med " +
                 $"{(RaceDistance >= carOrder[0].Distance ? 
                     $"{RaceDistance - carOrder[0].Distance} meter igjen til mål" : "når han går ut i siste runde")}");
        }

        public void StartingMetod()
        {
            if (_racingCars[0].Distance <= 0)
            {
                Console.Clear();
                StartText();
                Countdown();
            }
        }

        private void Countdown()
        {
            for (var i = 3; i >= 1; i--)
            {
                Console.WriteLine($"{i}\n");
                Thread.Sleep(1000);
            }
            Console.Clear();
        }

        private void StartText()
        {
            var nrOfCars = 0;
            foreach (var car in _racingCars)
            {
                nrOfCars++;
            }
            Console.WriteLine($"Dette blir et løp mellom {nrOfCars} biler og det skal kjøres {RaceDistance} m"); 
        }
        public bool EndRace()
        {
            foreach (var car in _racingCars) if (car.Distance > 1000) return false;
            return true;
        }

        private void ResetLaps()
        {
            if (EndRace()) _laps = 0;
        }

        public void PrintPodium()
        {
            var podium = _racingCars.OrderByDescending(car => car.Distance).Take(3); ;
            var nr = 1;
            foreach (var car in podium)
                Console.WriteLine($"{nr++}. plass {car.Name}");
            ResetLaps();
        }
    }
}
