using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Parrot : Pet 
    {
        public Parrot(String Name) : base(Name) 
        {
            Sound = "Hello human";
        }

        public override void eat()
        {
            Console.WriteLine(Name + " eats veggies");
        }
    }
}
