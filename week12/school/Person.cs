using System;
namespace school
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Person()
		{
			Id = -1;
			Name = "N/A";
		}

		public Person(int id, string name)
		{
			Id = id;
			Name = name;
		}

        public override string ToString()
        {
            return Id + ". " + Name;
        }
    }
}

