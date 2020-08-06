using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwithCases
{
    class Program
    {
        static void Main(string[] args)
        {


            int input = 1;

            //Console.ReadLine(); figure this out Ben

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing bro?");
                    break;
                default:
                    Console.WriteLine("This is defalult. It will execute if no other case is evaluted as true. Defaults are not required");
                    break;
            }

            // DayOfWeek today = DateTime.Today.DayOfWeek;
            DayOfWeek monday = DayOfWeek.Monday;

            //switch (today)
            switch (monday)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("There is so much to remember Ben... Pull your head out of your ass and pay attention");
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Hey it's almost Friday buddy!!!");
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;

                
            }
            /*
             * DayOfWeek today = DateTime.Today.DayOfWeek;
               switch (today)
               {
                case DayOfWeek.Monday:                  
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hey, it's Friday or almost Friday");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed");
                    break;
                }
            */

            /*Switch CaseChallenge:
             Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. 
            Output a different response for each value. If they respond out of range, let them know.*/


            Console.WriteLine("On a scale of 1 to 5, how are you feeling today Ben?");
            //String feelingScale = Console.ReadLine();


            /* switch (feelingScale)
             {
                 case "1":
                     Console.WriteLine("You must feel like your are tyring to learn to code.");
                     break;
                 case "2":
                     Console.WriteLine("Do you need a Snickers Bar?");
                     break;
                 case "3":
                     Console.WriteLine("Do you need a hug?.");
                     break;
                 case "4":
                     Console.WriteLine("Keep Moving Forward!");
                     break;
                 case "5":
                     Console.WriteLine("You are SuperMAN!.");
                     break;
             }*/


            String feelingScale = Console.ReadLine();
            int feelingScale = int.Parse(feelingScale);
            switch (feelingScale)
            {
                case 1:
                    Console.WriteLine("You must feel like your are tyring to learn to code.");
                    break;
                case 2:
                    Console.WriteLine("Do you need a Snickers Bar?");
                    break;
                case 3:
                    Console.WriteLine("Do you need a hug?.");
                    break;
                case 4:
                    Console.WriteLine("Keep Moving Forward!");
                    break;
                case 5:
                    Console.WriteLine("You are SuperMAN!.");
                    break;



            }

            Console.ReadLine();


}
}
}





