namespace Section2.Inheritance
{
    public class Text : PresentationObject
	{
		public int FontSize { get; set; }
		public string FontName { get; set; }

		public void AddHypperlink(string url)
		{
			Console.WriteLine("We added a link to" + url);
		}
	}
}

