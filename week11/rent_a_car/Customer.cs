using System;
namespace rent_a_car
{
	public class Customer
	{
		public String Vat { get; set; }
		public String Phone { get; set; }

		public Customer(String v, String p)
		{
			Vat = v;
			Phone = p;
		}

        public override string ToString()
        {
			return "VAT: " + Vat + ", phone: " + Phone;
        }
    }
}

