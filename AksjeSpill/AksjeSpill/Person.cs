namespace AksjeSpill
{
    internal class Person
    {
        private string Name;
        private double _bankAccount;
        public List<Stock> _ownedStocks;

        public Person(string name)
        {
            Name = name;
            _bankAccount = 1000;
            _ownedStocks = new List<Stock>();
        }

        public void BuyStock(Stock stock)
        {
            if (stock.Value <= _bankAccount)
            {
                _bankAccount -= stock.Value;
                _ownedStocks.Add(stock);
            }
        }

        public void Inventory()
        {
            Console.WriteLine(Name);
            Console.WriteLine(_bankAccount);
            foreach (var stock in _ownedStocks)
            {
                Console.WriteLine(stock.Name);
                Console.WriteLine(stock.Value);
            }
            Console.WriteLine();

        }

        public void UpdateStockPrice(List<Stock> stocklist)
        {
            foreach (var stock in stocklist)
            {
                foreach (var ownedStock in _ownedStocks)
                {
                    if (ownedStock.Name == stock.Name)
                    {
                        ownedStock.Value = stock.Value;
                    }
                }
            }
        }
    }
}
