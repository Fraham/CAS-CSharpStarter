using System;

namespace _4_StartingWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Fey Ijaware", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            /*
                The logic

                First we create an account with the name `Fey Ijaware` which has an initial balance of 1000
                We then withdraw 500 from the account
                Leaving the account with a balance of 500
                Then we make a deposit of 100
                Which increases the account balance to 600

                Mess with the numbers and change the amount of withdraws and deposit and see how the account history changes
            */
        }
    }
}
