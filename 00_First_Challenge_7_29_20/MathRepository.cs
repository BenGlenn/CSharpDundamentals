using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MathMachine
{
    public class MathRepository
    {

        string numOneAdd;
        string numTwoAdd;
        double numOneDecimal;
        double numTwoDecimal;

        public void AddNumbers()
        {
            Console.Write("Enter your first number: ");
            string numOneAdd = Console.ReadLine();


            Console.Write("Enter your second number: ");
            string numTwoAdd = Console.ReadLine();
            Console.WriteLine();

            numOneDecimal = Convert.ToDouble(numOneAdd);
            numTwoDecimal = Convert.ToDouble(numTwoAdd);

            Console.Write("Your answer is: ");
            Console.WriteLine(numOneDecimal + numTwoDecimal);

        }

        public void SubtractNumbers()
        {
            Console.Write("Enter your first number: ");
            string numOneAdd = Console.ReadLine();


            Console.Write("Enter your second number: ");
            string numTwoAdd = Console.ReadLine();
            Console.WriteLine();

            numOneDecimal = Convert.ToDouble(numOneAdd);
            numTwoDecimal = Convert.ToDouble(numTwoAdd);

            Console.Write("Your answer is: ");
            Console.WriteLine(numOneDecimal - numTwoDecimal);

        }

        public void MultiplyNumbers()
        {
            Console.Write("Enter your first number: ");
            string numOneAdd = Console.ReadLine();


            Console.Write("Enter your second number: ");
            string numTwoAdd = Console.ReadLine();
            Console.WriteLine();

            numOneDecimal = Convert.ToDouble(numOneAdd);
            numTwoDecimal = Convert.ToDouble(numTwoAdd);

            Console.Write("Your answer is: ");
            Console.WriteLine(numOneDecimal * numTwoDecimal);

        }

        public void DivideNumbers()
        {
            Console.Write("Enter your first number: ");
            string numOneAdd = Console.ReadLine();


            Console.Write("Enter your second number: ");
            string numTwoAdd = Console.ReadLine();
            Console.WriteLine();

            numOneDecimal = Convert.ToDouble(numOneAdd);
            numTwoDecimal = Convert.ToDouble(numTwoAdd);

            Console.Write("Your answer is: ");
            Console.WriteLine(numOneDecimal / numTwoDecimal);

        }

        public void DecimalNumbers()
        {
            Console.Write("Enter your first number: ");
            string numOneAdd = Console.ReadLine();
         

            Console.Write("Enter your second number: ");
            string numTwoAdd = Console.ReadLine();
            Console.WriteLine();

            numOneDecimal = Convert.ToDouble(numOneAdd);
            numTwoDecimal = Convert.ToDouble(numTwoAdd);

            Console.Write("Your answer is: ");
            Console.WriteLine(numOneDecimal + numTwoDecimal);

        }


    }
}
