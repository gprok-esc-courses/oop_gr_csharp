using System;
namespace rent_a_car
{
	public class Person : Customer 
	{
		public String Name { get; set; }

		public Person(String v, String p, String n) : base(v, p)
		{
			Name = n;
		}

        public override string ToString()
        {
            return Name + ", " + base.ToString();
        }
    }
}

