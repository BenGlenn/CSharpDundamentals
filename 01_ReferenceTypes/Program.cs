﻿using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings
            string declared;
            declared = "This is assignment.";

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName);

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"{firstName} {lastName} you have a really messed up name! What do you think of that asshole?");
            string comeBack = Console.ReadLine();

            Console.WriteLine($"{firstName} you smell like beef and cheese! Do you ever shower?");

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            string interpolatedFullName = $"{firstName} {lastName}";
            string concatenatedFullName = firstName + " " + lastName;
        


            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);
            Console.WriteLine(concatenatedFullName);

            // Collections
            // Array
            string[] stringArray = { "Hello", "World", firstName, lastName, };

            string thirdItem = stringArray[2];
            Console.WriteLine("The third item is " + thirdItem);

            stringArray[0] = "Hey Man!";
            Console.WriteLine(stringArray[0]);


         

            //List
            // the first part of the bellow code is the type of list ( it does not make the list) it has to say new list... That makes the new list... 



            List<string> listOfString = new List<string>();
            List<string> anotherReference = listOfString;

            listOfString.Add("Hello there");


            Queue<int> firstInFirstOut = new Queue<int>();
            firstInFirstOut.Enqueue(37);
            int output = firstInFirstOut.Dequeue();

            Stack<int> firstInLastOut = new Stack<int>();

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(43, "Ben");
            Console.WriteLine("Your instructor is" + keyAndValue[43]);

        





            Console.ReadLine();



        }
    }
}
