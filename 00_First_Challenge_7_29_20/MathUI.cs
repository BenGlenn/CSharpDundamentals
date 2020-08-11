using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MathMachine
{
    class MathUI
    {

        private bool _isRunning = true;
        private readonly MathRepository _mathRepository = new MathRepository();

        public void Start()
        {
            OpeningGreeting();
        }

        private void OpeningGreeting()
        {
            Console.Write(
            "Welcome to the Math Machine!\n" +
            "I can ADD, SUBTRACT, MULTIPLY, and DIVIDE.\n");
            while (_isRunning)
            {
                var userInput = GetMenuSelection();
                OpenOptions(userInput);
            }
        }

        private string GetMenuSelection()
        {
           
            Console.Write(
                "1. ADD\n" +
                "2. SUBTRACT\n" +
                "3. MULTIPLY\n" +
                "4. DIVIDE\n" +
                "5. DECIMALS\n" +
                "Choose one of the 5 options:");
            string userInput = Console.ReadLine();
            return userInput;
        }
      
        private void OpenOptions(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You Choose Addition.");
                    _mathRepository.AddNumbers();
                    Console.WriteLine();

                    break;
                case "2":
                    Console.WriteLine("You Choose Subtraction.");
                    _mathRepository.SubtractNumbers();
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("You Choose Multiplication.");
                    _mathRepository.MultiplyNumbers();
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine("You Choose Division.");
                    _mathRepository.DivideNumbers();
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine("Try a number with a Decimal.");
                    _mathRepository.DecimalNumbers();
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine("I can calculate anything!\n" + 
                "Press any key to try again");
            Console.ReadKey();
            Console.Clear();
            return;
        }
    }
}
