using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    internal class Latte : Beverage
    {
        public Latte() : base("Latte")
        {
            Sizes.Add(new Size("Small", 3.1));
            Sizes.Add(new Size("Medium", 3.9));
            Sizes.Add(new Size("Large", 4.5));
        }
    }
}
