using System.Collections.Generic;
using System.Linq;

namespace MusteritakipApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Customer()
        {
            Transactions = new List<Transaction>();
        }

        public decimal GetBalance()
        {
            return Transactions.Sum(t => t.Amount);
        }

        public decimal GetTotalDebit()
        {
            return Transactions.Where(t => t.Amount < 0).Sum(t => t.Amount) * -1;
        }

        public decimal GetTotalCredit()
        {
            return Transactions.Where(t => t.Amount > 0).Sum(t => t.Amount);
        }
    }
}