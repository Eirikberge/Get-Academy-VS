namespace AksjeSpill
{
    internal class Stock
    {
        public string Name;
        public double Value;
        private Random Random;

        public Stock(string name)
        {
            Name = name;
            Value = 100;
        }

        public void ChangeValue()
        {
            var random = new Random();
            var newRandomNr = random.Next(-6,6);
            Value = Value * 1+(newRandomNr);
        }

    }
}
