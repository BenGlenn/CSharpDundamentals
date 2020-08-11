using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamPart_01
{
    public class DeveloperRepository
    {
        //This holds the list of teams//
        public List<DeveloperTeams> _developerTeams = new List<DeveloperTeams>();

        //This adds to the list of teams//
        public void AddContentToDeveloperTeams(DeveloperTeams content)
        {
            _developerTeams.Add(content);
        }

        //This gives the abilty to find a time by ID//
        public DeveloperTeams GetTeamInfo(double teamId)
        {
            foreach (DeveloperTeams item in _developerTeams)
            {
                if (item.TeamID == teamId)
                {
                    return item;
                }
            }
            return null;
        }

        public bool RemoveTeamById(DeveloperTeams teamId)
        {
            bool removed = _developerTeams.Remove(teamId);
            return removed;
        }




    }
}

