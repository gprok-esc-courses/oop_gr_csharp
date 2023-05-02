using System;
namespace rent_a_car
{
	public class Company : Customer
	{
		public String Title { get; set; }
		public String Type { get; set; }

		public Company(String v, String p, String ti, String ty) : base(v, p)
		{
			Title = ti;
			Type = ty;
		}

        public override string ToString()
        {
            return Title + ", " + Type + ", " + base.ToString();
        }
    }
}

