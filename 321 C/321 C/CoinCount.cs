namespace _321_C
{
    internal class CoinCount
    {
        public int Value;
        public int Count;


        public CoinCount(int value, int count)
        {
            Value = value;
            Count = count;
        }

        public static CoinCount[] GetCoinCountArray()
        {
            var coinCounts = new CoinCount[]
            {
                new CoinCount(5, 3),
                new CoinCount(10, 2),
                new CoinCount(10, 11),
            };
            return coinCounts;
        }

        public int CoinsValue()
        {
            return Value * Count;
        }
    }

}
