namespace Section2.Inheritance
{
    public class PresentationObject
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public void Copy()
		{
			Console.WriteLine("object copy");
		}

		public void Duplicate()
		{
			Console.WriteLine("object duplicate");
		}

	}
}

