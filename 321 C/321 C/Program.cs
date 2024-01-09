namespace _321_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coinCountArray = CoinCount.GetCoinCountArray();
            var totalValue = 0;
            foreach (var coin in coinCountArray)
            {
                totalValue += coin.CoinsValue();
            }

            Console.WriteLine(totalValue);
        }
    }
}
