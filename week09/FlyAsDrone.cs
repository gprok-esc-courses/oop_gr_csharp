using System;
namespace ducks
{
	public class FlyAsDrone : FlyBehavior
	{
		public FlyAsDrone()
		{
		}

        public void fly()
        {
            Console.WriteLine("Flying as Drone");
        }
    }
}

