using System;
namespace FactoryPattern
{
	public class GrilledCheese : ISandwiches
	{
		public GrilledCheese()
		{
		}

        public void SandwhichType()
        {
            Console.WriteLine("cheese and toasted bread");
        }
    }
}

