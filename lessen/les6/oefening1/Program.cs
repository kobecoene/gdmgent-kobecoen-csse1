using System;

namespace les6
{
	class Program
	{
		static void Main(string[] args)
		{
			object o = null;
			try
			{
				int i = (int)o;   // Error  
			}
			catch (NullReferenceException e)
			{
				Console.WriteLine("NFE " + e.StackTrace);
			}
			catch (InvalidCastException e)
			{

				Console.WriteLine("ICE " + e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine("E: " + e.StackTrace);
			}
			finally
			{
				Console.WriteLine("Finally");
			}
		}
	}
}
