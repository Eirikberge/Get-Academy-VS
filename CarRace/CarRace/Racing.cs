using System.ComponentModel.Design;

namespace CarRace
{
    internal class Racing
    {
        private List<Car> _racingCars = new List<Car>();
        private Random random = new Random();

        public void Drive(Car car)
        {
            car.ChangeDistance(car);
            ChangeSpeed(car);
            Console.WriteLine($"{car.Distance}");
        }

        private void ChangeSpeed(Car car)
        {
            if (car.Distance < 500) car.ChangeSpeed(car, 10);
            else if (car.Speed > 0) car.ChangeSpeed(car, -10);
        }

        public void DoubleRace(Car car1, Car car2)
        {
            car1.SetNewSpeed(car1, random.Next(60, 200));
            car2.SetNewSpeed(car2, random.Next(60, 200));
            
            car1.ChangeDistance(car1);
            car2.ChangeDistance(car2);
            
            Console.WriteLine($"{car1.Name} har kjørt {car1.Distance}");
            Console.WriteLine($"{car2.Name} har kjørt {car2.Distance}");
            Console.WriteLine()
            ;
        }
        public string WinnerText(Car car1, Car car2)
        {
            if (car1.Distance > car2.Distance) return RaceWinnerText(car1);
            return RaceWinnerText(car2);
        }
        //public string WinnerText(Car car1, Car car2) =>
        //    RaceWinnerText(car1.Distance > car2.Distance ? car1 : car2);

        private string RaceWinnerText(Car car)
        {
            return $"{car.Name} er vinner med {car.Distance}";
        }

        public void AddToRace(Car car)
        {
            _racingCars.Add(car);
        }

        public void RaceWithManyCars()
        {
            foreach (var car in _racingCars)
            {
                car.SetNewSpeed(car, random.Next(60,200));
                car.ChangeDistance(car);
                Console.WriteLine($"{car.Name.PadRight(15)} - {car.Distance}".PadLeft(20));
            }
            Console.WriteLine();
        }

        public bool EndRace()
        {
            foreach (var car in _racingCars) if (car.Distance < 1000) return true;
            return false;
        }
        //public bool EndRace() => _racingCars.Any(car => car.Distance < 1000);


        public void PrintPodium()
        {
            var podium = _racingCars.OrderByDescending(car => car.Distance).Take(3); ;
            var nr = 1;
            foreach (var car in podium)
                Console.WriteLine($"{nr++}. plass {car.Name} med {car.Distance}");
        }
    }
}
