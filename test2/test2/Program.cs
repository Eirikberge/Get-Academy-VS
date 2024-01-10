namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var totalValue = 0;
            var coinCounts = new CoinCount[]
            {
                new CoinCount(1, 7),
                new CoinCount(5, 3),
                new CoinCount(10, 2),
                new CoinCount(10, 11),
            };

            foreach (var coin in coinCounts)
            {
                totalValue += coin.CalcValue();
            }
            Console.WriteLine($"{totalValue}");

        }
    }
}
//let coinCounts = [
//{value: 1, count: 7},   // 7 stk. 1-kroninger
//{ value: 5, count: 3},   // 3 stk. 5-kroninger
//{ value: 10, count: 2},  // 2 stk. 10-kroninger
//{ value: 10, count: 11}, // 11 stk. 10-kroninger
//];