using System;
namespace ducks
{
	public class FlyWithWings : FlyBehavior
	{
		public FlyWithWings()
		{
		}

        public void fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
}

