using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
           int total = 1;

            //While is called an iteration... 
            while (total != 10)
            {
                Console.WriteLine(total);
                //reassigning the value of total to equal total +1
                //total = total++; or
                total = total + 1;
            }

            total = 0;
            // condition is n parentheses.. just like all the syntaz with Conditionals 
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached");
                    break;
                }
                Console.WriteLine("somevalue");
                total++;
            }

            Random rand = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {

                    continue; // continue with disregard the rest of the loop, and will go back to the top to loop agian

                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int studentCount = 21;

            // 1 Starting Point
            // 2 While this condition is true, keep looping
            // 3 What we do after each interation/loop
            // 4 Code we execute each interation/loop

            // for 1      //2 condition         //3
            for (int counter = 0; counter < studentCount; counter++)
            {
                //4 code to execute
                Console.WriteLine(counter);
                //Console.ReadKey();

            }

            string[] students = { "Ben", "Chris", "Matt", "Amanda", };

            for (int i = 0; i < students.Length; i++)
            {                              // i the index of our array, it will return the value of that indx 
                Console.WriteLine($"Welcome to class {students[i]}!");
            }
            //        // 3     //2    //4  //1
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class... or are they INstructors??");
                //Console.ReadKey();
            }
            string oneStudent = students[2];
            foreach (char letter in oneStudent)
            {
                Console.WriteLine(letter + " this should just be one leter of the 3rd name in the students array");
                //Console.ReadKey();
            }

            string myName = "Casey Michael Wilson";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Do While Loop   -- Do something oonce, and then continue to do that while the conditions is ture 
            // WHile loop is a pre-test meaning it will test the conditional for true/false before first iteration
            //Do while loop is a post-test, it will run 1 iteration and then test the conditional for true/false before continuing to the next iteration

            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            }
            //condition
            while (iterator < 5);





            Console.ReadLine();
            //Console.ReadKey(); */

            int GetMaxValue(int[] numbers, int upperBound)
            {
                int maxValue = numbers.Max();

                if (maxValue < upperBound)
                {
                    return maxValue;
                }
                else
                {
                    return 0;
                }
             
            }
            Console.ReadLine(upperBound);

        }
    }
}