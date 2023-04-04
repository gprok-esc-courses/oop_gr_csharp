using System;
namespace ducks
{
	public class FlyNoWay : FlyBehavior
	{
		public FlyNoWay()
		{
		}

        public void fly()
        {
            Console.WriteLine("Cannot fly");
        }
    }
}

