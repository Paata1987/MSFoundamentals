using System;
using Humanizer;

namespace BankyStuffLibrary
{
    internal class Transaction
    {

        public decimal Amount { get; }

        public string AmountForhumans
        {
            get
            {
              return   ((int)Amount).ToWords();

            }
        }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
