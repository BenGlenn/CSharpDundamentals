using _09_Interfaces_WorkignWithDI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkignWithDI
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        // Dependency Injection with Methods
        private void PayDebt(ICurrency payment)
        {
            //_debt = _debt - payment.Value;
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt. You have ${_debt} left to pay.");
        }
        [TestMethod]
        public void PayDebtTest()
        {
            _debt = 9000.01m;

            var dollar = new Dollar();
            PayDebt(dollar);
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(315.72m));
            // Starting Debt - whatever I paid above
            var expectedDebt = 9000.01m - 317.72m;
            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(234.15m);

            // New Up Transactins with Test Data
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);
            // Calling Methods
            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            // Asserts
            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());

            Assert.AreEqual(234.15m, secondTransaction.GetTransactionType());

       
        }
    }
}
