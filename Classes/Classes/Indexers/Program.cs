using System;
namespace Classes.Indexers
{
    class Program
	{
		static void Main(string[] args)
		{
            var cookie = new HttpCookie();
			cookie["name"] = "Axel";
			Console.WriteLine(cookie);
        }
		
	}
}

