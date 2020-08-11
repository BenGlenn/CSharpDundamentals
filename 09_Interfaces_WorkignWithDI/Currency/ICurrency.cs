using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkignWithDI.Currency
{
    public interface ICurrency
    {
        // Name - What the Currencey is called
        string Name { get; }

        // Value - How much the Currency is worth
        decimal Value { get; }
    }
}
