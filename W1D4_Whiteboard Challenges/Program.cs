using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4_Whiteboard_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables. One of type int, one of type string, and one of type DateTime.
            string myName = "Ben";
            int myAge = 47;
            DateTime now = DateTime.Now;

            Console.WriteLine(myName);
            Console.WriteLine(myAge);
            Console.WriteLine(now);

            ChallengeDay4 challengeDay4 = new ChallengeDay4();
            //challengeDay4.SubtractNum(2, 3);
            Console.WriteLine(challengeDay4.SubtractNum(2, 3));
            Console.ReadLine();



            /* int banana = SubtractNum(100);
             Console.WriteLine(banana);

             //Create a method that subtracts two numbers and returns the value.

             int numOne = 30;
             int numTwo = 9;

             int SubtractNum(int num)
             {
                 return num - 5;
             }

             int apple = numOne - numTwo;
             Console.WriteLine(apple);

             int banana = SubtractNum(100);
             Console.WriteLine(banana); */


            //Create a method that takes two strings from the user and outputs a string.

            Console.WriteLine("Hello. My name is Skippy, what is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("How do you feel about peanut butter");
            string yourAnswer = Console.ReadLine();

            string comboPackStrings = $"This is how {yourName} feels about peanut butter... {yourAnswer}";
            Console.WriteLine(comboPackStrings);

            //Write a switch case that asks the user if they are wearing clothes.
            Console.WriteLine("Ben, yes or no, are you wearing cloths today? I think I am seeing a little more than I would like...");

            String clothingOption = Console.ReadLine();

            switch (clothingOption)
            {
                case "Yes":
                    Console.WriteLine("I'm sorry my mistack.");
                    break;
                case "No":
                    Console.WriteLine("Do you mind putting on a towel or something?");
                    break;
                default:
                    Console.WriteLine("I don't understand.");
                    break;
            }

            //Write an if else statement that uses a boolean to check if the user is happy. You can start off with something like: bool happy = true;


            Console.WriteLine("Are you happy to be learning C# Ben, yes or no?");
            bool feelings = true;
            string benFeelings = feelings.ToString();
            benFeelings = Console.ReadLine();
            //Console.WriteLine(benFeelings);

            if (benFeelings == "yes")
            {
                Console.WriteLine("That's good, cuz you got a long way to go bro!");
            }
            else
            {
                Console.WriteLine("You better pull your head of of your ass and start liking is cuz you got a long way to go bro!");
            }

            Console.WriteLine("On a scale from 1 to 5. 5 being the best, how are you feeling today Ben?");
            string feelingScale = Console.ReadLine();

            if (feelingScale == "1")
            {
                Console.WriteLine("Dang bro you must be trying to learn how to code at the ripe old age of 47!");
            }

            if (feelingScale == "2")
            {
                Console.WriteLine("Do you need and Annie hug. She is the bestest hugger ever!");
            }
            if (feelingScale == "3")
            {
                Console.WriteLine("There is nothing wrong with a 3. You just need to keep moving forward bro.");
            }
            if (feelingScale == "4")
            {
                Console.WriteLine("4 is not bad... Maybe you will get lucky this weekend and jump to a 5!");
            }
            if (feelingScale == "5")
            {
                Console.WriteLine("Did you wife promise you some action this weekend... Well done Mr. Man!");
            }
            else
            {
                Console.WriteLine("I am speachless... I hope you have a great day!");
            }





            //Write an if, else if, else that asks the user how much money they make a year. Check ranges between 1,000-10,000,  11,000-50,000, and 51,000-100,000. Output to the test runner based on each salary range. Have a else statement to prepare for the user not giving their salary range or out of the ranges we are checking. */


            Console.WriteLine("How much green do you bank in a year?");
            int yearSalary = int.Parse(Console.ReadLine());

            if (yearSalary >= 1000 || yearSalary <= 10000)
            {
                Console.WriteLine("That's not bad but maybe it's time to thing about your future!");
            }
            else 
            {
                if ((yearSalary >= 11000 || yearSalary <= 50000))
                {
                    Console.WriteLine("That's a nice living");
                }
                if ((yearSalary >= 51000 || yearSalary <= 100000))
                {
                    Console.WriteLine("Can I barrow 50 bucks?");
                }
                else
                {
                    Console.WriteLine("You might want to get a job");
                }
            }
           
            


            Console.ReadLine();

        }
    }
}





















