using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Bank
{
    internal class Transactions
    {
        private DateTime _time;
        private BankAccount _bankAccount;
        private List<Transactions> _transactionsList;
        private int _depositAmount = 0;
        private int _whithdrawAmount = 0;

        public Transactions()
        {
            _time = DateTime.Now;
            _transactionsList = new List<Transactions>();
        }

        public void Deposit(BankAccount _bankAccount, int amountIn)
        {
            _bankAccount._ammount += amountIn;
            Console.WriteLine($"Det er satt inn {amountIn} kl {_time}  til {_bankAccount._name}");

            Transactions transaction = new Transactions
            {
                _time = DateTime.Now,
                _bankAccount = _bankAccount,
                _depositAmount = amountIn,
            };

            _transactionsList.Add(transaction);

        }

        public void Whithdraw(BankAccount _bankAccount, int amountOut)
        {

            _bankAccount._ammount -= amountOut;
            Console.WriteLine($"Det er tatt ut {amountOut} kl {_time} til {_bankAccount._name}");
            Transactions transactions = new Transactions
            {
                _time = DateTime.Now,
                _bankAccount = _bankAccount,
                _whithdrawAmount = amountOut,
            };

            _transactionsList.Add(transactions);
        }

        public void Transfer(BankAccount fromAccount, BankAccount toAccount, int amount)
        {
            if (fromAccount._ammount > amount)
            {
                fromAccount._ammount += amount;
                toAccount._ammount -= amount;
            }
        }

        public void GetAllTransactions(BankAccount _bankAccount)
        {
            foreach (var transaction in _transactionsList)
            {
                Console.WriteLine();
                if (transaction._depositAmount > 0)
                {
                    Console.WriteLine($"Tidspunkt: {transaction._time}");
                    Console.WriteLine($"Bankkonto: {transaction._bankAccount._name}");
                    Console.WriteLine($"Innskuddsbeløp: {transaction._depositAmount}");
                }
                else if (transaction._whithdrawAmount > 0)
                {
                    Console.WriteLine($"Tidspunkt: {transaction._time}");
                    Console.WriteLine($"Bankkonto: {transaction._bankAccount._name}");
                    Console.WriteLine($"Uttaksbeløp: {transaction._whithdrawAmount}");
                }

                Console.WriteLine();

                // Lage en transasjonsmetode for å korte ned koden.
            }
        }

    }
}
