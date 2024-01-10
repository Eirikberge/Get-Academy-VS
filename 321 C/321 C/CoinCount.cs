namespace _321_C
{
    internal class CoinCount
    {
        private int Value;
        private int Count;

        public CoinCount(int value, int count)
        {
            Value = value;
            Count = count;
        }

        public static CoinCount[] GetCoinCounts()
        {
            return new CoinCount[]
            {
                new CoinCount(5, 3),
                new CoinCount(10, 2),
                new CoinCount(10, 11),
            };
        }

        public int CoinsValue()
        {
            return Value * Count;
        }

        public void GetTotalCount()
        {
            var coinCounts = GetCoinCounts();
            var totalValue = 0;

            foreach (var coin in coinCounts)
            {
                totalValue += CoinsValue();
            }

            Console.WriteLine(totalValue);
        }
    }

}
