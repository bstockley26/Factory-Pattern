using System;
namespace FactoryPattern
{
    public class Club : ISandwiches
	{
		public Club()
		{
		}

        public void SandwhichType()
        {
            Console.WriteLine("turkey, ham and bacon");
        }
    }
}

