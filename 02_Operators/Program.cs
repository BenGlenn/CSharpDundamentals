using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 22;
            int numTwo = 15;

            // Addition: +
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            // subtraction: -
            int difference = numOne - numTwo;
            Console.WriteLine(difference);

            //Mutliplication
            int product = numOne * numTwo;
            Console.WriteLine(product);

            //Division

            int quottient = numOne / numTwo;
            Console.WriteLine(quottient);

            // Remainder %
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            DateTimeOffset timeZoneDate = DateTimeOffset.Now;
            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);

            TimeSpan banana = now - someDay; 
            Console.WriteLine(banana);



            // Comparison Operators
            Console.WriteLine("Enter your age:");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);

            bool equals = age == 42;
            Console.WriteLine("User is 42: " + equals);

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            bool userIsAdam = name == "Adam";
            Console.WriteLine("User is Adam:" + userIsAdam);

            bool userIsNotAdam = name != "Adam";
            Console.WriteLine("User is not Adam: " + userIsAdam);

            // > >= == < <=
            bool isOlder = age > 12;
            bool lessThanOrEqual = age <= 12;
            // false cuz that pull from two seperate lists
            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            // this is true cuz they pull from the same list 
            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = firstList;
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine($"The lists are the same {listsAreEqual}");

            bool isTeen = isOlder && lessThanOrEqual;
            bool or = isOlder || lessThanOrEqual;

            bool trueValue = true;
            bool falseValue = false;
            // OR comparison
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;
            // AND comparison
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;
          








            Console.ReadLine();
        }
    }
}
