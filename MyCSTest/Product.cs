using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    public class Product
    {
        public string          Name    { get; private set; }
        public Brand           Brand   { get; private set; }
        public ulong           Code    { get; private set; }
        public MeasuringUnit   Unit    { get; private set; }
        public uint            Amount  { get; private set; }

        public Product(string name, Brand brand, ulong code, MeasuringUnit unit, uint amount)
        {
            Name = name;
            Brand = brand;
            Code = code;
            Unit = unit;
            Amount = amount;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1} ({2}), {3}{4}", Code, Name, Brand, Amount, Unit);
        }


    }
}
