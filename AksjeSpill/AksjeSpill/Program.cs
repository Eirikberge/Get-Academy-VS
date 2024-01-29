namespace AksjeSpill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Martin");
            var stocks = new List<Stock>
            {
                new Stock("Telenor"),
                new Stock("Equinor"),
                new Stock("Storebrand"),
                new Stock("Gjensidige"),
                new Stock("Kongsberg Gruppen"),
                new Stock("Frontline"),
                new Stock("Aker BP"),
                new Stock("Rec Silicon"),
                new Stock("Norwegian"),
                new Stock("DNB"),
            };

            while (true)
            {
                Console.Clear();
                person.UpdateStockPrice(stocks);
                person.Inventory();
                foreach (var stock in stocks)
                {
                    stock.ChangeValue();
                    Console.WriteLine($"{stock.Name}  {stock.Value}");
                }
                Console.WriteLine("hva vil du gjøre, kjøpe, selge holde");
                var cmd = Console.ReadLine();
                var cmdInt = Convert.ToInt32(cmd);
                for (var i = 0; i < stocks.Count; i++)
                {
                    if (cmdInt == i+1)
                    {
                        person.BuyStock(stocks[i]);
                    }
                }
            }
        }
    }
}
