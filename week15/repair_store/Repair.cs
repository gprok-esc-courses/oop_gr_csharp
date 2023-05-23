using System;
namespace repairstore
{
	public class Repair
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public Clerk Clerk { get; set; }
		public Customer Customer { get; set; }
		public List<Engineer> Engineers { get; set; }
		public String? DateClosed { get; set; }


		public Repair(int id, string description, Clerk clerk, Customer customer) 
		{
			Id = id;
			Description = description;
			Clerk = clerk;
			Customer = customer;
			Engineers = new List<Engineer>();
			DateClosed = null;
		}

        public override string ToString()
        {
			return Id + ". " + Description + ", " + Customer.Name;
        }
    }
}

