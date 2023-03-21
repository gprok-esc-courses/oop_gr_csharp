using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal abstract class Pet
    {
        public String Name { get; set; }
        public String Sound { get; set; }      


        public Pet(String Name) {
            this.Name = Name;       
        }

        public abstract void eat();
    }
}
