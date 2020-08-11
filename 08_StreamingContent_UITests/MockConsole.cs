using _08_StreamingContent_ConsoleUI.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_UITests
{
    class MockConsole : IConsole
    {
        // This will be the list of steps the "user" woult take
        public Queue<string> UserInput;

        // Whatever is output from the ProgramUI
        public string Output = "";

        public MockConsole(IEnumerable<string> input)
        {
            // Declares a new Queue that is populated with the givne IEnumerable
            UserInput = new Queue<string>(input);
        }

        public void Clear()
        {
            Output += "Called Clear Method\n";
            //Output = Output + "Called Clear Method\n"; This is the other way to understand the above line//
        }

        public ConsoleKeyInfo ReadKey()
        {
            Output += "Key was pressed";
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            return UserInput.Dequeue();
        }

        public void Write(string s)
        {
            Output += s;
        }

        public void WriteLine(string s)
        {
            Output += s + "\n";
        }

        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
