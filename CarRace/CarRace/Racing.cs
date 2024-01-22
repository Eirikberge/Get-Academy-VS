using System.ComponentModel.Design;

namespace CarRace
{
    internal class Racing
    {
        public void Drive(Car car)
        {
            car.ChangeDistance(car);
            ChangeSpeed(car);
            Console.WriteLine($"{car.Distance}");
        }

        private void ChangeSpeed(Car car)
        {

            if (car.Distance < 500)
            {
                car.ChangeSpeed(car, 10);
            }
            else if (car.Distance > 500 && car.Speed > 0)
            {
                car.ChangeSpeed(car, -10);
            }
        }

        public void DoRace(Car car1, Car car2)
        {
            var random = new Random();
            car1.SetNewSpeed(car1, random.Next(60, 200));
            car2.SetNewSpeed(car2, random.Next(60, 200));
            
            car1.ChangeDistance(car1);
            car2.ChangeDistance(car2);
            
            Console.WriteLine($"{car1.Name} har kjørt {car1.Distance}");
            Console.WriteLine($"{car2.Name} har kjørt {car2.Distance}");
            Console.WriteLine("")
            ;
        }

        public string WinnerText(Car car1, Car car2)
        {
            if (car1.Distance > car2.Distance)
            {
                return RaceWinnerText(car1);
            }
            return RaceWinnerText(car2);
        }

        private static string RaceWinnerText(Car car)
        {
            return $"{car.Name} er vinner med {car.Distance}";
        }
    }
}
