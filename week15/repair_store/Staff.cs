using System;
namespace repairstore
{
	public class Staff : Person
	{
		public Decimal Salary { get; set; }
		
		public Staff(int id, string name, Decimal salary) :
			base(id, name)
		{
			Salary = salary;
		}
	}
}

