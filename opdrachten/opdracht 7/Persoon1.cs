using System;
using System.Threading.Tasks;

namespace Opdracht6
{
	class Persoon1
	{
		public string voornaam;
		protected char geslacht;

		public char Geslacht
		{
			get => geslacht;
			set
			{
				geslacht = value;
			}
		}

		public string Familienaam
		{
			get;
			set;
		}

		public Persoon1(string familienaam, string voornaam)
		{
			Familienaam = familienaam;
			this.voornaam = voornaam;
		}

		public Persoon1(string familienaam, string voornaam, char geslacht)
		{
			Familienaam = familienaam;
			this.voornaam = voornaam;
			Geslacht = geslacht;
		}

		public void logOutput()
		{
			Console.WriteLine(string.Format("Output: voornaam: {1}, familienaam: {0}, Geslacht: {2}, geslacht: {3}", this.voornaam, Familienaam, Geslacht, this.geslacht));
		}
	}
}
