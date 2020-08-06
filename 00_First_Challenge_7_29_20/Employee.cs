using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassChallenges_00
{
    public enum EmployeeType { Manager, Tec, Janitor, }
    class Employee
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }
        public int Years { get; set; }
        public EmployeeType TypeOfEmployee { get; set; }

        //See of you can make this work... 

        DateTimeOffset timeZoneDate = DateTimeOffset.Now;
        DateTime now = DateTime.Now;
        DateTime someDay = new DateTime(1978, 1, 1);
    }
}
}
