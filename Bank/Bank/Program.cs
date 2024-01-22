namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAccount1 = new BankAccount("Eirik");
            var bankAccount2 = new BankAccount("Martin");
            var bankAccount3 = new BankAccount("Elon");
            var transaction = new Transactions();

            transaction.Deposit(bankAccount1, 1000);
            bankAccount1.GetBalance();

            transaction.Deposit(bankAccount2, 1000);
            transaction.Deposit(bankAccount3, 1000);

            transaction.Transfer(bankAccount2, bankAccount3, 500);

            bankAccount2.GetBalance();
            bankAccount3.GetBalance();

            transaction.Whithdraw(bankAccount1, 250);

            transaction.GetAllTransactions(bankAccount1);
        }
    }
}
