using System;
namespace Classes.Properties
{

    class Program
	{
		static void Main(string[] args)
		{
			var person = new Person(new DateTime(2000, 1, 1));
			Console.WriteLine(person.Age);
		}
	}
}

