using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
    

            // Week 1 Day 3 Challenge 
            /* 1.Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.
               2.Next, do the same, except only print the letter if it's an 'i'. If it's any other letter, print "Not an i".
               Bonus: After that, print the number of letters in the word(do this with code, not by counting manually and hard-coding the number).
               Another Bonus: In part 2, also determine if the letter is 'L'.If it is, print 'L'.*/

            string myName = "Supercalifragilisticexpialidocious";
            Console.WriteLine(myName.Length);
            foreach (char letter in myName)

            {
                /* if (letter != ' ')
                 {
                    // Console.WriteLine(letter);
                 }*/
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
            }
            Console.ReadLine();
        }
    }

}












