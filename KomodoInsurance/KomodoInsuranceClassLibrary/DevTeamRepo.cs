using System;
using System.Collections.Generic;
using System.Text;

namespace KomodoInsuranceClassLibrary
{
    public class DevTeamRepo
    {
        private List<DevTeam> _teamDirectory = new List<DevTeam>();
        private int _currentDevID = 0;

        public bool CreateTeam(string name, List<Developer> devsOnTeam)
        {
            int startingTeamCount = _teamDirectory.Count;
            DevTeam teamToAdd = new DevTeam()
            {
                Name = name,
                Developers = devsOnTeam,
                ID = _currentDevID
            };
            _currentDevID++;
            _teamDirectory.Add(teamToAdd);
            return _teamDirectory.Count > startingTeamCount;
        }
        public List<DevTeam> ReturnTeams()
        {
            return _teamDirectory;
        }
        public bool UpdateTeam(int id, string name)
        {
            foreach (var team in _teamDirectory)
            {
                if(id == team.ID)
                {
                    team.Name = name;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteTeam(int id)
        {
            foreach (var team in _teamDirectory)
            {
                if (id == team.ID)
                {
                    _teamDirectory.Remove(team);
                    return true;
                }
            }
            return false;
        }    
    }
}
