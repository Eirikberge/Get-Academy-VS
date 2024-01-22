namespace CarRace
{
    internal class Car
    {
        public string Name;
        private int Speed;
        public int Distance;

        public Car(string name)
        {
            Name = name;
            Speed = 10;
            Distance = 0;
        }

        public void Drive()
        {
            Distance += Speed;
            ChangeSpeed();
        }

        private void ChangeSpeed()
        {
            if (Distance >= 500 && Speed > 10) Speed -= 10;
            else Speed += 10;
        }

        public void GetEndDescription()
        { 
            Console.WriteLine($"{Name} er fremme og har parkert");
        }

        public void Race(Car car2)
        {
            var random = new Random();
            var randomSpeed1 = random.Next(60, 200);
            var randomSpeed2 = random.Next(60, 200);

            Distance += randomSpeed1;
            car2.Distance += randomSpeed2;
        }
    }
}
