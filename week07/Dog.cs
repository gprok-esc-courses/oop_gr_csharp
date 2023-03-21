using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Dog : Pet
    {
        public Dog(String Name) : base(Name) 
        {
            this.Sound = "Wooof";
        }

        public override void eat()
        {
            Console.WriteLine(Name + " eating bones");
        }
    }
}
