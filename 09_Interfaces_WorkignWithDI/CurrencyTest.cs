using System;
using _09_Interfaces_WorkignWithDI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkignWithDI
{
    [TestClass]
    public class CurrencyTest
    {
        [TestMethod]
        public void PennyTest()
        {
            ICurrency penny = new Penny();

            Assert.AreEqual("Penny", penny.Name);
            Assert.AreEqual(0.01m, penny.Value);
        }

        [TestMethod]
        public void DimeTest()
        {
            ICurrency dime = new Dime();

            Assert.AreEqual("Dime", dime.Name);
            Assert.AreEqual(0.10m, dime.Value);
        }

        [TestMethod]
        public void DollorTest()
        {
            ICurrency dollar = new Dollar();

            Assert.AreEqual("Dollar", dollar.Name);
            Assert.AreEqual(1m, dollar.Value);
        }



    }
}
