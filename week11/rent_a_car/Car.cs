using System;
namespace rent_a_car
{
	public class Car
	{
		public String Plate { get; set; }
		public String Brand { get; set; }
		public int Km { get; set; }

		public Car(String p, String b, int k)
		{
			Plate = p;
			Brand = b;
			Km = k;
		}

        public override string ToString()
        {
			return Plate + ", " + Brand + ", km: " + Km;
        }
    }
}

