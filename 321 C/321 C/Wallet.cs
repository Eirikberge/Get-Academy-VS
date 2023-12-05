namespace _321_C
{
    internal class Wallet
    {
        private CoinCount[] _coinCounts;
        public  Wallet()
        {
            _coinCounts = new CoinCount[]
            {
                new CoinCount(5, 3),
                new CoinCount(10, 2),
                new CoinCount(10, 11),
            };
        }

        public CoinCount[] GetCounts()
        {
            return _coinCounts;
        }
        
    }
}