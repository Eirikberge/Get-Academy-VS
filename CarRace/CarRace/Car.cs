namespace CarRace
{
    internal class Car
    {
        public string Name { get; private set; }
        public int Speed { get; private set; }
        public int Distance { get; private set; }

        public Car(string name)
        {
            Name = name;
            Speed = 10;
            Distance = 0;
            
        }

        public void ChangeSpeed(Car car, int change)
        {
            car.Speed += change;
        }

        public int ChangeDistance(Car car) => car.Distance += car.Speed;


        public void SetNewSpeed(Car car, int newSpeed)
        {
            car.Speed = newSpeed;
        }

        public void ClearDistance(Car car)
        {
            car.Distance = 0;
        }
    }
}
