using System;
namespace repairstore
{
	public class Store
	{
		public List<Customer> Customers { get; set; }
		public List<Clerk> Clerks { get; set; }
		public List<Engineer> Engineers { get; set; }
		public List<Repair> Repairs { get; set; }

		public Store()
		{
			StoreDatabase db = new StoreDatabase();
			Customers = db.GetCustomers();
			Clerks = db.GetClerks();
			Engineers = db.GetEngineers();
			Repairs = new List<Repair>();
		}

		public void PrintRepairs()
		{
			foreach (Repair r in Repairs)
			{
				Console.WriteLine(r);
			}
		}

        public void PrintOpenRepairs()
        {
            foreach (Repair r in Repairs)
            {
                if (r.DateClosed == null)
                {
                    Console.WriteLine(r);
                }
            }
        }

        public void CloseRepair()
        {
            Console.Write("Give repair ID:");
            int id = Int32.Parse(Console.ReadLine());
            Console.Write("Give Date:");
            string date = Console.ReadLine();
            Repair repair = GetRepairById(id);
            if(repair != null)
            {
                repair.DateClosed = date;
            }
        }

		public void AddEngineer()
		{
            Console.Write("Give repair ID:");
            int id = Int32.Parse(Console.ReadLine());
            Console.Write("Give engineer ID:");
            int eid = Int32.Parse(Console.ReadLine());
            Repair repair = GetRepairById(id);
            Engineer engineer = GetEngineerById(eid);
            repair.Engineers.Add(engineer);
        }

		public void AddRepair()
		{
			Console.Write("Give repair ID:");
			int id = Int32.Parse(Console.ReadLine());
            Console.Write("Give Description:");
			string description = Console.ReadLine();
            Console.Write("Give clerk ID:");
            int clerkId = Int32.Parse(Console.ReadLine());
			Clerk clerk = GetClerkById(clerkId);
            Console.Write("Give customer ID:");
            int customerId = Int32.Parse(Console.ReadLine());
            Customer customer = GetCustomerById(clerkId);

			if(customer != null && clerk != null)
			{
				Repair repair = new Repair(id, description, clerk, customer);
				Repairs.Add(repair);
			}
			else
			{
				Console.WriteLine("ERROR: customer or clerck not found");
			}
        }


		public Clerk? GetClerkById(int id)
		{
			foreach(Clerk c in Clerks)
			{
				if(c.Id == id)
				{
					return c;
				}
			}
			return null;
		}

        public Engineer? GetEngineerById(int id)
        {
            foreach (Engineer c in Engineers)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        public Repair? GetRepairById(int id)
        {
            foreach (Repair c in Repairs)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        public Customer? GetCustomerById(int id)
        {
            foreach (Customer c in Customers)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }


        public void PrintCustomers()
		{
			foreach(Customer c in Customers)
			{
				Console.WriteLine(c);
			}
		}

        public void PrintClerks()
        {
            foreach (Clerk c in Clerks)
            {
                Console.WriteLine(c);
            }
        }

        public void PrintEngineers()
        {
            foreach (Engineer c in Engineers)
            {
                Console.WriteLine(c);
            }
        }
    }
}

