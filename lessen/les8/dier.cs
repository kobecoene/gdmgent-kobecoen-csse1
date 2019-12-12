using System;

namespace les8
{

	public class Dier
	{
		public Dier() { }
		public void VoedingGeven()
		{
			Console.WriteLine("Basisklasse Dier: VoedingGeven");
		}
	}

	public class Hond : Dier
	{
		public Hond() { }
		// public void VoedingGeven()
		// {
		// 	Console.WriteLine("Basisklasse Dier: VoedingGeven");
		// }

	}

	public class Dier1
	{
		public Dier1() { }
		public virtual void VoedingGeven()
		{
			Console.WriteLine("Subklasse Dier1: VoedingGeven");
		}
	}
}
