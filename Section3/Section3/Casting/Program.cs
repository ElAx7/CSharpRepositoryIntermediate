using System.IO;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Section3.Casting
{
    class Program
	{
		static void Main(string[] args)
		{
			Shape shape = new Text();
			Text text = (Text)shape;
		}
	}
}

