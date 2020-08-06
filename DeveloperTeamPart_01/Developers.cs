using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamPart_01
{
    //The Developer class should have an ID, a last name, and whether or not they have access to a Pluralsight account.
    //Create a Team class that allows us to store the team's Name and ID, along with the list of Developers on that team.
    //The Team should also be able to add new members(Developers) and remove members(Developers) by their ID.
    // 1 Give the developer class an ID, last name, access to the account 
    // 2 Ctreate a Team Class, store the name and id info. and who is on the Team 
    // Need a Repository that has the ability to. 
    // Hold all the existing Teams 
    // Have the ability to create new teams 
    // get a team by its ID
    // Delete a team by its ID
    // 3 make a test to prove your code works 

    public class Developer
    {
        public Developer() { }
        public Developer(string lastName, int developerId, bool access)
        {
            LastName = lastName;
            ID = developerId;
            Access = access;
        }
      

        public string LastName { get; set; }
        public int ID { get; set; }
        public bool Access { get; set; }

    }
      
    public class TeamVikings 
    {
        public TeamVikings(string teamName, int teamId, List<TeamVikings> onTheTeams) 
          
        {
            TeamName = teamName;
            TeamID = teamId;
            WhoOnTeam = onTheTeams;
        }

        public string TeamName { get; set; }
        public int TeamID { get; set; }
        public List<TeamVikings> WhoOnTeam { get; set; }
           
               
       
    }      
          
      
        
       


}
