using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Data
{
    public class DevTeam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Developer> Developers { get; set; }
    }
}