using System;
namespace repairstore
{
	public class Clerk : Staff
	{
		public Clerk(int id, string name, Decimal salary) :
			base(id, name, salary)
		{

		}


        public override string ToString()
        {
            return "CLR: " + Id + " " + Name;
        }
    }
}

