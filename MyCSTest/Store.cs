using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    public class Store
    {

        public string Name { get; private set; }
        public string Chain { get; private set; }
        public string Address { get; private set; }

        public Store(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}){2}", Name, Chain, (!Address.Equals(string.Empty) ? ", " + Address : ""));
        }

    }
}
