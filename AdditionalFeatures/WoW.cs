using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class WoW
    {
        public WoW(string race, string clas)
        {
            Race = race;
            Clas = clas;
        }
        public WoW(string race) : this(race, "Warrior") { }

        public string Race;
        public string Clas;
    }
}
