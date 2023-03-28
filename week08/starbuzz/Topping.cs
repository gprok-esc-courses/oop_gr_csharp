using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    internal class Topping
    {
        public string Name { get; set; }    
        public double Price { get; set; }   

        public Topping(string name, double price) 
        { 
            this.Name = name;
            this.Price = price;
        }
    }
}
