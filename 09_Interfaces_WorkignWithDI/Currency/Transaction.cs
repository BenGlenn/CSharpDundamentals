using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkignWithDI.Currency
{
    public class Transaction
    {
        private readonly ICurrency _curency;

        public Transaction(ICurrency currency)
        {
            _curency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        public DateTimeOffset DateOfTransaction { get; }

        public decimal GetTransactionValue()
        {
            return _curency.Value;
        }

        public string GetTransactionType() => _curency.Name;
    }
}
