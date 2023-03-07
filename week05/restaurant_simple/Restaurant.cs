using System;
namespace restaurant
{
	public class Restaurant
	{
		public List<Customer> Customers { get; set; }

		public Restaurant()
		{
			Customers = new List<Customer>();
		}

		public void AddCustomer(Customer customer)
		{
			Customers.Add(customer);
		}

		public Customer FindCustomerByPhone(string phone)
		{
			foreach(Customer customer in Customers)
			{
				if(customer.Phone == phone)
				{
					return customer;
				}
			}
			return null;
		}
	}
}

