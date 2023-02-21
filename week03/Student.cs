using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Student
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public Address Address { get; set; }

        // Constructors
        public Student(string Name)
        {
            this.Name = Name;
            this.Major = "N/A";
        }
        public Student(string Name, string Major)
        {
            this.Name = Name;
            this.Major = Major;
        }
   
        public override string ToString()
        {
            return Name + ", major: " + Major;
        }

    }
}
