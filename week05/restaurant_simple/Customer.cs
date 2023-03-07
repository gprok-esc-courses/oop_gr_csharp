using System;
namespace restaurant
{
	public class Customer
	{
		public static int id = 0;
        public int ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }

        public Customer(string name, string address, string phone)
		{
			id++;
			this.ID = id;
			this.Name = name;
			this.Address = address;
			this.Phone = phone;
		}

        public override string ToString()
        {
			return ID + ". " + Name;
        }
    }
}

