using System;
using System.Collections.Generic;
using System.Text;

namespace KomodoClasses.Repos
{
    public class DevTeam
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        public DevTeam() { }
        public DevTeam(int id, string name)
        {
            TeamID = id;
            TeamName = name;
        }
    }
}
