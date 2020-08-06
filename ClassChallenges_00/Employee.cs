using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassChallenges_00
/*Komodo insurance wants a simple app that allows them to create employees.
For now we want just the basics for defining the employee object itself.
We want each employee to have a 

unique employee 
id number, 
first name,
last names, 
age,
number of years at Komodo Insurance.*/

    /* property is the what... access modifire - who can use it... what type of property... name the property... */
{
    public enum EmployeeType { Manager, Tec, Janitor, }
    class Employee
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }
        public int Tenure { get; set; }
        public EmployeeType TypeOfEmployee { get; set; }
        public DateTime HireDate { get; set; }


        //See of you can make this work... 

        DateTimeOffset timeZoneDate = DateTimeOffset.Now;
        DateTime now = DateTime.Now;
        DateTime someDay = new DateTime(1978, 1, 1);
    }
}

