using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectNou
{
	class DressCodeException : ApplicationException
	{

		private readonly string message = " You are not wearing an Elf costume, and your are underage!";

		public DressCodeException()
		{
			Console.WriteLine(message);
		}





	}
}
