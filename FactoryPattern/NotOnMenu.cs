using System;
namespace FactoryPattern
{
    public class NotOnMenu : ISandwiches
	{
		

        public void SandwhichType()
        {
            Console.WriteLine("not on menu");
        }
    }
}

