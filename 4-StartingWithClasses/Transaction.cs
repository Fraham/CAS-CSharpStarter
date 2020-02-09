using System;

namespace _4_StartingWithClasses
{
    public class Transaction
    {
        /*
            All of these properties only have `get`
            Once the property has been set it can not be updated
        */
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        /*
            This is the constructor for this class
            All of the values for the properties need to be set during the construction
        */
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
