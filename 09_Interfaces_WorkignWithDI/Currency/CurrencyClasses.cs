using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkignWithDI.Currency
{
    public class Penny : ICurrency
    {
        // ' >= != => NOT THE SAME( => Fat Arrow)
        public string Name => "Penny";

        public decimal Value // this is the SAME as line 12 but blocked out //
        {
            get
            {
                return .01m;
            }
        }
    }

    public class Dime : ICurrency
    {
        public string Name => "Dime";

        public decimal Value => .10m;
    }

    public class Dollar : ICurrency
    {
        public string Name => "Dollar";

        public decimal Value => 1m;
    }

    public class ElectronicPayment : ICurrency
    {
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }

        public string Name => "Electronic Payment";

        public decimal Value { get; }
    }
}
