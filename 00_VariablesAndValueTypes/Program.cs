using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes //
{
    // basic type with a spicific amount of shit 
    enum PastryType { Cake, Cupcake, Eclaire }

    class Program
    {
        static void Main(string[] args)
        {
            //Booleans
            // Declaration - type name;
            bool isDeclared;

            //Assigning a value. The = is always an assignment To == is equality 
            isDeclared = true;

            // Declaring  it and assigning and initial value
            bool isDeclaratinAndInitialized = false;

            // logic that might lead to ture... 
            isDeclaratinAndInitialized = true;

            // Characters
            char letter = 'a';
            // string name = "Benny"
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\'';

            // n means new line 



            // Whole Numbers
            byte byteExample = 255;
            sbyte signByte = -128;
            short shortExample = 32767;
            int intMin = -2147483648;
            uint tunsightedInt = 4000000000;
            long longExample = 9223372036854775807;

            Console.WriteLine(longExample = 1); //this will cause and overflow thing to happen//

            // Decimals this is for percesion... what the hell does that mean Ben... Beats the hell out of me :-)

            float floatExample = 1.320561408513f;
            double doubleEample = 1.320561408513d;
            decimal decimalExample = 1.320561408513m;

            // Structs is an objec that has a little more info... has extra funtionality... they have a default value... 

            DateTime today = DateTime.Today;
            DateTime tomorrow = new DateTime(2020, 7, 28);


            // Enums there are a few built in Enums 

            PastryType myPastery = PastryType.Cake;

            Console.WriteLine(specialCharacter);
        }
    }
}
