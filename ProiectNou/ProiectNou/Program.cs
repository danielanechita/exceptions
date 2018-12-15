using System;

namespace ProiectNou
{
	class Program
	{  
		

		static void Main(string[] args)
		{
			/*
			try
			{
				int b = 100;
				int a = b / 0;
				Console.WriteLine(a);

			}

			catch(DivideByZeroException exception)
			{
				Console.WriteLine("Ups, something is wrong");
				Console.WriteLine(exception.Message);
				Console.WriteLine(exception.StackTrace);
				
			}
			
	          */
			try
			{
				Person person = new Person(15);
				Person person1 = new Person(-1);
				
				Person person3 = new Person(81);


			}
			catch (ArgumentException e)
			{
				Person person2 = new Person(2);
				//Console.WriteLine(e)
				Console.WriteLine(e.Message + e.GetType());

				//throw;
			}
			catch(DressCodeException ex)
			{
				Console.WriteLine(ex.Message + ex.GetType());
			}
			


		}
	}
}
