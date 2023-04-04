using System;
namespace ducks
{
	public class RubberDuck : Duck
	{
		public RubberDuck() : base(new FlyNoWay())
		{
		}
	}
}

