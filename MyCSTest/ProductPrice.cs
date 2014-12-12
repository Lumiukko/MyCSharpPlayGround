using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSTest
{
    public class ProductPrice
    {
        public Product Product { get; private set; }
        public Store Store { get; private set; }
        public float Price { get; private set; }
        public DateTime Time { get; private set; }

        public ProductPrice(Product product, Store store, float price, DateTime time)
        {
            Product = product;
            Store = store;
            Price = price;
            Time = time;
        }
    }   
}
