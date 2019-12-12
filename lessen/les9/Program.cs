using System;

namespace les9
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public interface ILogging
		{
			public void logOutput(string input);
		}

		public class A : ILogging
		{
			public string aantal
			{
				get;
				set;
			}
			public A()
			{

			}

		}
	}

}
