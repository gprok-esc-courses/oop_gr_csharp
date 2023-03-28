using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    internal class Espresso : Beverage
    {
        public Espresso() : base("Espresso")
        {
            Sizes.Add(new Size("Single", 2.5));
            Sizes.Add(new Size("Dopio", 3.7));
        }
    }
}
