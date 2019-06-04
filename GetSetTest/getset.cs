using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetTest
{
    class getset
    {
        private string name = "N/A";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
