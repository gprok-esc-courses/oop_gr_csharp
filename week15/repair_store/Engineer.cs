using System;
namespace repairstore
{
	public class Engineer : Staff
	{
		public string Specialty { get; set; }
		
		public Engineer(int id, string name, Decimal salary, string specialty) :
			base(id, name, salary)
		{
			Specialty = specialty;
		}

        public override string ToString()
        {
			return "ENG: " + Id + " " + Name + " SP:" + Specialty;
        }
    }
}

