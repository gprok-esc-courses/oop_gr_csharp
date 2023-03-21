using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Duck : Pet
    {
        public Duck(String Name) : base(Name) 
        { 
            this.Sound = "Quack";   
        }

        public override void eat()
        {
            Console.WriteLine(Name + " eating seeds");
        }
    }
}
