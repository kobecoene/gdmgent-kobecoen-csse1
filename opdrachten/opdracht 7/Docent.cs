using System;

namespace Opdracht6
{
	class Docent : Gebruiker
	{
		public Docent(string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht)
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
				fullname += voornaam.ToLower() + Familienaam.ToLower().Substring(0, 2);
			}
			else
			{
				fullname += voornaam.ToLower().Substring(0, 4) + Familienaam.ToLower().Substring(0, 2);
			}
			return fullname;
		}

		private string GenerateLogin()
		{
			string fullname = "";
			if (voornaam.Length < 4)
			{
				fullname += voornaam.ToLower() + Familienaam.ToLower().Substring(0, 2);
			}
			else
			{
				fullname += voornaam.ToLower().Substring(0, 4) + Familienaam.ToLower().Substring(0, 2);
			}
			return fullname + "@arteveldehs.be";
		}

		protected new string GeneratePassword()
		{
			string pw = "Tea";
			for (int i = 0; i < 10; i++)
			{
				pw += Convert.ToString(rnd.Next(10));
			}
			return pw + "cher";
		}
	}
}