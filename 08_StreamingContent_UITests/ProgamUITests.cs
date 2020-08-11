using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using _08_StreamingContent_ConsoleUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_StreamingContent_UITests
{
    [TestClass]
    public class ProgamUITests
    {
        [TestMethod]
        public void GetList_OutputShouldContainStreamingContent()
        {
            // Arrange
            // Get the commands we want to run
            // Initialize our Console and UI
            var commandList = new List<string>() { "1", "6" };
            var console = new MockConsole(commandList);
            var program = new ProgramUI(console);

            // Act
            // Run the applicaiton
            program.Start();
            Console.WriteLine(console.Output);

            // Assert
            // Check for specified content in Output
            Assert.IsTrue(console.Output.Contains("Hello Kitty Island Adventure"));

        }

        // steps to test selection 3 , Title, Description, maturity 1-9, stars1-5, year, 1-8. 2 Title, 6

        [TestMethod]
        public void AddToList_ShouldFindByTitle()
        {
            // -- Arrange
            var description = "Some Custom Description";
            var commandlist = new string[] { "3", "Title", description, "8", "5", "2020", "3", "2", "Title", "6" };
            var console = new MockConsole(commandlist);
            var ui = new ProgramUI(console);

            ui.Start();
            Console.WriteLine(console.Output);

            Assert.IsTrue(console.Output.Contains(description));
        }
    }
}
