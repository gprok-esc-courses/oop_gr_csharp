using System;
namespace rent_a_car
{
	public class CarRental
	{
		public DatabaseSingleton db;

		public CarRental()
		{
			db = DatabaseSingleton.getInstance();
		}

		public void PrintCars()
		{
            foreach (Car car in db.Cars)
            {
                Console.WriteLine(car);
            }
        }

		public void PrintCustomers()
		{
            foreach (Customer customer in db.Customers)
            {
                Console.WriteLine(customer);
            }
        }
	}
}

