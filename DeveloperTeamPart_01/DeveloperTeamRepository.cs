using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamPart_01
{
    class DeveloperTeamRepository
    {
        public List<Developer> _developerContents = new List<Developer>();
        //CRUD
        //Create 
        public void AddContentToDirectory(Developer content) 
        {
            _developerContents.Add(content);
        }

        public List<TeamVikings> _teamVikingsContents = new List<TeamVikings>();
       
        public void AddContentToDirectory(TeamVikings content)
        {
            _teamVikingsContents.Add(content);
        }

        // My thought process... foreach item in the list of TeamVikings if that item matches the ID number of the developerID get that item or else return nothing 

       public TeamVikings GetTeamInfo(int teamId)
        {
            foreach (TeamVikings item in _teamVikingsContents)
            {
                if (item.TeamID == teamId)
                {
                    return item;
                }
            }
            return null;
        }
    }
}

