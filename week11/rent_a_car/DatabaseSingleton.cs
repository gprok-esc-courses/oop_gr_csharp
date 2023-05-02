using System;
namespace rent_a_car
{
	public class DatabaseSingleton
	{
		private static DatabaseSingleton? databaseSingleton = null;
		public List<Car> Cars { get; set; }
		public List<Customer> Customers { get; set; }

		private DatabaseSingleton()
		{
			Cars = new List<Car>();
			Customers = new List<Customer>();
			LoadCars();
			LoadCustomers();
		}

        private void LoadCars()
        {
            Cars.Add(new Car("AZX6734", "VW", 1078));
            Cars.Add(new Car("NZO9098", "Toyota", 3901));
            Cars.Add(new Car("EHN1287", "Seat", 2000));
        }

        private void LoadCustomers()
        {
            Customers.Add(new Person("10983", "693456", "John Doe"));
            Customers.Add(new Company("00987", "699999", "Aek Constructions", "AE"));
            Customers.Add(new Person("00987", "693121", "Mary Doe"));
            Customers.Add(new Person("90919", "694001", "Nick Doe"));
            Customers.Add(new Company("00991", "68888", "PAO Constructions", "Ltd"));
        }

        public static DatabaseSingleton getInstance()
		{
			if(databaseSingleton == null)
			{
				databaseSingleton = new DatabaseSingleton();
			}
			return databaseSingleton;
		}
	}
}

