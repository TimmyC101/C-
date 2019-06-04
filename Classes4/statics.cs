using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    static class statics
    {
        public static string firstName;
        public static string middleName;
        public static string lastName;

        static statics()
        {
            firstName = "Timothy";
            middleName = "Davis";
            lastName = "Calhoun";
        }
    }
}
