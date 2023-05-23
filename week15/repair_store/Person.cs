using System;
namespace repairstore
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }

		// CONSTRUCTOR 
		public Person(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}

