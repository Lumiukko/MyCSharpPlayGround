using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    public class Brand
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }

        public Brand(string name, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return Name + " © " + Manufacturer;
        }

    }
}
