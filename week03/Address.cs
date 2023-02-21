using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Address
    {
        public string Street { get; set; }
        public int No { get; set; }
        public string City { get; set; }    

        public Address(string Street, int No, string City) {
            this.Street = Street;
            this.No = No;
            this.City = City;
        }

        public override string ToString()
        {
            return Street + " " + No + ", " + City;
        }
    }
}
