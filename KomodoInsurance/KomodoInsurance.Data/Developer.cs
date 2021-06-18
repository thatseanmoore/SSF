using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Data
{
    public class Developer
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public bool HasPluralSight { get; set; }
        public object Id { get; set; }
        public bool IsPluralSightCertified { get; set; }

        public Developer()
        {

        }
        public Developer(string name, bool hasPluralSight)
        {
            Name = name;
            HasPluralSight = hasPluralSight;
        }
    }
}


