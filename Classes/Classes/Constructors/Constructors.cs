using System;
namespace Classes
{
	public class Order
	{

	}

	class Program
	{
		static void Main(string[] args)
		{
			var customer = new Customer();
			customer.Id = 1;
			customer.Name = "Axel";

			var order = new Order();
			customer.Orders = new List<Order>();
			customer.Orders.Add(order);

			Console.WriteLine(customer.Id);
			Console.WriteLine(customer.Name);
		}
	}
}

