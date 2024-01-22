namespace Bank
{
    internal class BankAccount
    {
        public string _name;
        public int _ammount;
        private List<BankAccount> _bankAccounts = new List<BankAccount>();

        public BankAccount(string name)
        {
            _name = name;
            _ammount = 0;
            _bankAccounts.Add(this);
        }

        public void GetBalance()
        {
            Console.WriteLine($"{_name} har {_ammount} på konto");
        }
    }
}
