using System;

namespace Opdracht6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Persoon1 person1 = new Persoon1("Kobe", "Coene", 'M');
			person1.voornaam = "Kristof";
			person1.Geslacht = 'M';
			person1.logOutput();
			Gebruiker gebruiker1 = new Gebruiker("Kristof", "Raes", 'M');
			gebruiker1.logOutput();
			Gebruiker gebruiker2 = new Gebruiker("Evelien", "Rutsaert", 'V');
			gebruiker2.logOutput();
			Student student1 = new Student("Evelien", "Rutsaert", 'V');
			student1.logOutput();
			Docent teacher1 = new Docent("Evelien", "Rutsaert", 'V');
			teacher1.logOutput();
		}
	}
}
