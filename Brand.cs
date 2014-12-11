using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    class Brand
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }

        public Brand(string name, string manufacturer)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return this.Name + " © " + this.Manufacturer;
        }

    }
}
