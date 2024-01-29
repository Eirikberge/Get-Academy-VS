namespace CarRace
{
    internal class Car
    {
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public int Speed { get; private set; }
        public int Distance { get; private set; }

        public Car(string name, string brand = "Lekebil")
        {
            Name = name;
            Speed = 10;
            Distance = 0;
            Brand = brand;
        }
        public int ChangeDistance(Car car) => car.Distance += car.Speed;

        public void ChangeSpeed(Car car, int newSpeed) => car.Speed = newSpeed;

        public void ResetDistance(Car car) => car.Distance = 0;
    }
}