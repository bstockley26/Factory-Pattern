using System;
namespace FactoryPattern
{
	public class SandwichFactory
	{
		public static ISandwiches MakeSandwich(string userinput)
		{
			switch (userinput.ToLower())
			{
				case "club sandwich":
					return new Club();
				case "grilled cheese":
					return new GrilledCheese();
				default:
					return new NotOnMenu();
			}
		}
	}
}

