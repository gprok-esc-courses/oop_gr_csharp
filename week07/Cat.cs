using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Cat : Pet
    {
        public Cat(String Name) : base(Name) 
        { 
            this.Sound = "Mieow";
        }

        public override void eat()
        {
            Console.WriteLine(Name + " consuming fish");
        }
    }
}
