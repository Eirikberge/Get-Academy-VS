namespace Stable
{
    internal class Horse
    {
        public string Name { get; private set; }
        private int Speed;
        public bool IsFed;
        public bool IsRacing;
        public int DistanceRan;

        public Horse(string name, int speed)
        {
            Name = name;
            Speed = speed;
            IsFed = false;
            IsRacing = false;
            DistanceRan = 0;
        }
    }
}
