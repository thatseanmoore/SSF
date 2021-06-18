using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Data
{
    public class DeveloperRepo
    {

        private readonly List<Developer> _developerDirectory = new List<Developer>();
        private int _currentId = 0;

        public bool AddDeveloper(string name, bool hasPluralSight)
        {
            int startingDevCount = _developerDirectory.Count;
            Developer developerToAdd = new Developer()
            {
                HasPluralSight = hasPluralSight,
                Name = name,
                ID = _currentId
            };
            _currentId++;
            _ = _developerDirectory.Count > startingDevCount;
            return _developerDirectory.Count > startingDevCount;

        }
        public List<Developer> ReturnDevelopers()
        {
            return _developerDirectory;
        }
        public Developer ReturnDevelopersById(int id)
        {
            foreach (var developer in _developerDirectory)
            {
                if (developer.ID == id)
                    return developer;
            }
            return null;
        }

        public bool UpdateDeveloper(int id, string name, bool hasPluralSight)
        {
            foreach (var dev in _developerDirectory)
            {
                if (dev.ID == id)
                {
                    dev.Name = name;
                    dev.HasPluralSight = hasPluralSight;
                    return true;
                }

            }
            return false;
        }
        public bool DeleteDeveloper(int id)
        {
            foreach (var dev in _developerDirectory)
            {
                if (dev.ID == id)
                {
                    _developerDirectory.Remove(dev);
                    return true;
                }
            }
            return false;
        }
        public void SeedContent()
        {
            AddDeveloper("Mike Jones", true);
            AddDeveloper("Karen Jones", true);
            AddDeveloper("Steve Johnson", false);
            AddDeveloper("Michael Jonesville", true);
        }



    }
}
