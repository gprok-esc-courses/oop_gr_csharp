using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    internal class Beverage
    {
        public string Name { get; set; }    
        public List<Size> Sizes { get; set; }
        public Beverage(string name) 
        { 
            this.Name = name;
            this.Sizes = new List<Size>();
        }
    }
}
