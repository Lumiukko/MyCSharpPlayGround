using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    class Product
    {
        public string          Name    { get; private set; }
        public Brand           Brand   { get; private set; }
        public ulong           Code    { get; private set; }
        public MeasuringUnit   Unit    { get; private set; }
        public uint            Amount  { get; private set; }

        public Product(string name, Brand brand, ulong code, MeasuringUnit unit, uint amount)
        {
            this.Name = name;
            this.Brand = brand;
            this.Code = code;
            this.Unit = unit;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return "[" + this.Code + "] " + this.Name + " (" + this.Brand.ToString() + "), " + this.Amount + this.Unit.ToString();
        }


    }
}
