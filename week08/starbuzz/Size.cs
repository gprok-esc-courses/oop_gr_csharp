using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    internal class Size
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Size(string Name, double Price) 
        { 
            this.Name = Name;
            this.Price = Price;
        }
    }
}
