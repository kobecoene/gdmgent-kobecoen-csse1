<<<<<<< HEAD
using System;


namespace Opdracht6
{
	class Student : Gebruiker
	{
		public Student(string familienaam, string voornaam, char geslacht) : base(familienaam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenerateUsername();
			this.login = GenerateLogin();
			this.wachtwoord = CreatePasswordHash(GeneratePassword(), CreateSalt());
		}

		private string GenerateUsername()
		{
			string fullname = "";
			if (voornaam.Length < 4)
			{
				fullname += voornaam.ToLower() + Familienaam.ToLower().Substring(0, 4);
			}
			else
			{
				fullname += voornaam.ToLower().Substring(0, 4) + Familienaam.ToLower().Substring(0, 4);
			}
			return fullname;
		}

		private string GenerateLogin()
		{
			string fullname = "";
			if (voornaam.Length < 4)
			{
				fullname += voornaam.ToLower() + Familienaam.ToLower().Substring(0, 4);
			}
			else
			{
				fullname += voornaam.ToLower().Substring(0, 4) + Familienaam.ToLower().Substring(0, 4);
			}
			return fullname + "@student.arteveldehs.be";
		}

		protected new string GeneratePassword()
		{
			string pw = "stu";
			for (int i = 0; i < 10; i++)
			{
				pw += Convert.ToString(rnd.Next(10));
			}
			return pw + "dent";
		}
	}
=======
using System;


namespace Opdracht6
{
	class Student : Gebruiker
	{
		public Student(string familienaam, string voornaam, char geslacht) : base(familienaam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenerateUsername();
			this.login = GenerateLogin();
			this.wachtwoord = CreatePasswordHash(GeneratePassword(), CreateSalt());
		}

		private string GenerateUsername()
		{
			string fullname = "";
			if (voornaam.Length < 4)
			{
				fullname += voornaam.ToLower() + Familienaam.ToLower().Substring(0, 4);
			}
			else
			{
				fullname += voornaam.ToLower().Substring(0, 4) + Familienaam.ToLower().Substring(0, 4);
			}
			return fullname;
		}

		private string GenerateLogin()
		{
			string fullname = "";
			if (voornaam.Length < 4)
			{
				fullname += voornaam.ToLower() + Familienaam.ToLower().Substring(0, 4);
			}
			else
			{
				fullname += voornaam.ToLower().Substring(0, 4) + Familienaam.ToLower().Substring(0, 4);
			}
			return fullname + "@student.arteveldehs.be";
		}

		protected new string GeneratePassword()
		{
			string pw = "stu";
			for (int i = 0; i < 10; i++)
			{
				pw += Convert.ToString(rnd.Next(10));
			}
			return pw + "dent";
		}
	}
>>>>>>> 5336f64b0c9d42cf5fad7ad1aa2e422af8863f8f
}