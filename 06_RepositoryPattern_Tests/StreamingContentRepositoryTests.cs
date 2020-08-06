using System;
using System.Collections.Generic;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("rubber", "A car tyre comes to life with the power to make people expolde and goes on a murderous rampage through the California desert.", MaturityRating.R, 5.8, 2010, GenreType.Thriller);

            _repo.AddContentToDirectory(_content);

        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue() { }
      

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()

       
        {
            //Arrange
            // This will be replaced with our [TestInitialize] method
            //Arrange();

            //Act
            bool removeResult = _repo.DeleteExistingContent(_content);
      
            // Triple A...

            // Arange --> setting up the playing field
            StreamingContentRepository repo = new StreamingContentRepository();
            StreamingContent orange = new StreamingContent();
            repo.AddContentToDirectory(orange);

            // ACT --> Get or run the code we want to test 
            List<StreamingContent> directory = repo.GetDirectory();

            bool directoryHasOrange = directory.Contains(orange);

            // Assert --> Using the assert class to verify the expected outcome
            Assert.IsTrue(directoryHasOrange);
       

 
        }

        [TestMethod]
        [DataRow("rubber", true)]
        [DataRow("toy story", false)]

        public void DeleteByTitle_ShouldReturnCorrectBool(string title, bool expectedResult)
        {
            // Arrange [TestInitialize]

            // Act
            bool actualResult = _repo.DeleteContentByTitle(title);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        
    }
}
