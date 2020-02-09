using System; // this import for logging to the console
using System.Collections.Generic; // this import for allowing for lists

namespace _4_StartingWithClasses
{
    public class BankAccount
    {
        /*
            This is the bank account number property
            This property only has a `get` so the value can not be updated directly
            It uses the value that was set in the constructor
        */
        public string Number { get; }

        /*
            This is the bank account owner property
            This property has both a `get` and `set`
        */
        public string Owner { get; set; }

        /*
            This is the balance property
            This property only has a `get` so the value can not be updated directly
            It using the logic to work out what the value needs to be returned as
        */
        public decimal Balance
        {
            get
            {
                decimal balance = 0;

                /*
                    Starting with a balance of zero
                    Loop through all the transactions made
                        Add the amount in each transaction to the running total
                    Return the balance amount
                */
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        /*
            This is the constructor method for this class
            Notice that the name of the constructor is the same as the class name
        */
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        /*
            This is a private variable for the instance
            No code from outside the class is able to see this variable
            So they only the code that can affect this variable has to be in this class
        */
        private List<Transaction> allTransactions = new List<Transaction>();

        /*
            This is a public method of it can be called from anywhere that has an instance of the class
            This method has a return type of void, so the method will not return any data
        */
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        /*
            This is a public method of it can be called from anywhere that has an instance of the class
            This method has a return type of void, so the method will not return any data
        */
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        /*
            This is a public method of it can be called from anywhere that has an instance of the class
            This method has a return type of string, so it must return a string object
        */
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}
