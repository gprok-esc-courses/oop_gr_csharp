using System;
namespace ducks
{
	public class Duck 
	{
		public FlyBehavior flyBehavior { get; set; }

		public Duck(FlyBehavior flyBehavior)
		{
			this.flyBehavior = flyBehavior;
		}
	}
}

