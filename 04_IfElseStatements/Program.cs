using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userIsHungry = true;

            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }
            //Console.ReadLine();

            int hoursSpentStuding = 17;
            if (hoursSpentStuding < 16)
            {
                Console.WriteLine("Are you even trying");
            }

            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the Netflix");
            }
            else
            {
                Console.WriteLine("You must stay home and finish your chores!");
            }

            Console.ReadLine();

            Console.WriteLine("How many hours did you sleep?");
            String input = Console.ReadLine();
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested.");
            }
            else
            {
                Console.WriteLine("You might be tired today.");
                if (totalHours < 4)
                {
                    Console.WriteLine("You should get more rest.");
                }
            }
            Console.ReadLine();

            Console.WriteLine("How old are you");
            string ageImput = Console.ReadLine();
            int age = Convert.ToInt32(ageImput);

            if (age > 17)
            {
                Console.WriteLine("You're an adult.");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("You are a kid.");
                }
                else if (age > 0)
                if (age > 0 && age <=6) is another option with out using the else 
                {
                    Console.WriteLine("You're far too young to be on a computer");
                }
                else
                {
                    Console.WriteLine("You're not born yet.");
                }

                if (age < 65 && age > 18)
                {
                    Console.WriteLine("Age is between 18 and 65");

                }

                if (age < 65 || age > 18)
                {
                    Console.WriteLine("You are middle aged");

                }

                if (age == 21)
                {
                    Console.WriteLine("you are 21");

                }

                if (age != 36)

                {
                    Console.WriteLine("Age is not equal to 36");

                }




            }
        }

    }
}
