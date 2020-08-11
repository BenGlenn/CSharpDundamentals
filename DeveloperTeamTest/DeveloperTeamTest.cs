using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DeveloperTeamPart_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Developer_Team_Test

{
    [TestClass]
    public class DeveloperTeamTest
    {
        private DeveloperRepository _repo;
        private DeveloperTeams _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new DeveloperRepository();
            _content = new DeveloperTeams("Vikings", 2345, OnTheTeam.Beth);

            _repo.AddContentToDeveloperTeams(_content);
        }
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            DeveloperRepository repo = new DeveloperRepository();
            DeveloperTeams orange = new DeveloperTeams("Bears", 5432, OnTheTeam.Ted);

            repo.AddContentToDeveloperTeams(orange);
         

            DeveloperTeams directory = repo.GetTeamInfo(orange.TeamID);

           // bool directoryHasOrange = directory.Contains(orange.TeamID);

            Assert.IsTrue(orange == directory);


        }





    }
}
