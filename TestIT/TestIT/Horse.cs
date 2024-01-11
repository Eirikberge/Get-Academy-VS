namespace TestIT
{
    internal class Horse
    {
        private string _name;
        public int _speed;
        private bool isFed;
        private bool isRacing;
        public int distanceRun;


        public Horse(string name, int speed)
        {
            _name = name;
            _speed = speed;
            isFed = false; 
            isRacing = false;
            distanceRun = 0;
        }

        public void FeedHorse(Horse horse)
        {
            horse.isFed = true;
        }

        public void Race(Horse horse)
        {
            horse.isRacing = true;
        }

        public void Run(Horse horse)
        {
            horse.distanceRun += horse._speed;

            Console.WriteLine($"{horse.distanceRun}");
        }
    }
}
