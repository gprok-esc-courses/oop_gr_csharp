using System;
namespace repairstore
{
	public class Customer : Person
	{
		public string Afm { get; set; }

		public Customer(int id, string name, string afm) :
			base(id, name)
		{
			Afm = afm;
		}

        public override string ToString()
        {
			return Id + " " + Name + ", " + Afm;
        }
    }
}

