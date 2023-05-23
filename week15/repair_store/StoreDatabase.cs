using System;
namespace repairstore
{
	public class StoreDatabase
	{
		public List<Customer> GetCustomers()
		{
			List<Customer> customers = new List<Customer>();
			customers.Add(new Customer(1, "Peter", "009988"));
            customers.Add(new Customer(2, "John", "005588"));
            customers.Add(new Customer(3, "Mike", "005488"));
            customers.Add(new Customer(4, "Ann", "009909"));
            customers.Add(new Customer(5, "Mary", "009928"));
            customers.Add(new Customer(6, "Nick", "009911"));
			return customers;
        }

		public List<Clerk> GetClerks()
		{
			List<Clerk> clerks = new List<Clerk>();
			clerks.Add(new Clerk(1, "Mike Smith", 900));
            clerks.Add(new Clerk(2, "Sue Jones", 1200));
            clerks.Add(new Clerk(3, "Susan Draw", 1100));
			return clerks;
        }

		public List<Engineer> GetEngineers()
		{
			List<Engineer> engineers = new List<Engineer>();
			engineers.Add(new Engineer(1, "Tom Sons", 1300, "Laptop"));
            engineers.Add(new Engineer(2, "Eric Tier", 1400, "Mobile"));
            engineers.Add(new Engineer(3, "Sally Field", 1300, "Printer"));
            engineers.Add(new Engineer(4, "Ike Tommy", 1000, "Laptop"));
            engineers.Add(new Engineer(5, "Nick Lions", 1500, "Console"));
			return engineers;
        }
	}
}

