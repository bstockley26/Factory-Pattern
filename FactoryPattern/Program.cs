namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like?");

            var order = Console.ReadLine();

            ISandwiches madeOrder = SandwichFactory.MakeSandwich(order);
            madeOrder.SandwhichType();
            
        }
    }
}