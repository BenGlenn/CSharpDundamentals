using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ternaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 31;

            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine("Age is over 17: " + isAdult);

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            // Ternary runctions are a way to write the if/else statment below in a more efficient manner

            Console.WriteLine((numTwo == 30) ? "True" : "False");

            Console.ReadLine();

            //function, Methos are functoin's that we define within a class... outside of a class it is just a function
            int BenValue(int perameter)
            {
                int doubleValue = perameter * 5;
                return doubleValue; 
            }
            

            int DoubleValue(int num)
            {
                return num * 2;
            }

            int TripleValue(int num)
            {
                return num * 3;
            }

            int dataToManipulate = 5;
            Console.WriteLine(dataToManipulate);

            int apple = BenValue(10);
            int banana = DoubleValue(127);
            int orange = DoubleValue(7);

            string userInput = Console.ReadLine();
            int manipulatedDate = (userInput == "double") ? DoubleValue(dataToManipulate) : TripleValue(dataToManipulate);

            Console.WriteLine(apple);
            Console.WriteLine(manipulatedDate);

            Console.ReadLine();
        }
    }
}
