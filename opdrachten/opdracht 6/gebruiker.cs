<<<<<<< HEAD
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace Opdracht6
{
	class Gebruiker : Persoon1
	{
		protected string gebruikersnaam;
		protected string wachtwoord;
		protected string login;

		protected Random rnd = new Random();

		public string Gebruikersnaam
		{
			get { return this.gebruikersnaam; }
		}

		public string Wachtwoord
		{
			get { return this.wachtwoord; }
		}

		public string Login
		{
			get { return this.login; }
		}

		public Gebruiker(string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht)
		{
			this.wachtwoord = CreatePasswordHash(GeneratePassword(), CreateSalt());
			this.gebruikersnaam = GenerateUsername();
			this.login = GenerateLogin();
		}

		public Gebruiker(string voornaam, string familienaam, char geslacht, string username, string login, string password) : base(voornaam, familienaam, geslacht)
		{
			this.gebruikersnaam = username;
			this.login = login;
			this.wachtwoord = CreatePasswordHash(password, CreateSalt());
		}

		private string GenerateUsername()
		{
			return voornaam + Familienaam;
		}

		private string GenerateLogin()
		{
			return voornaam + Familienaam + "@gebruikers.com";
		}

		protected string GeneratePassword()
		{
			string pw = "Use";
			for (int i = 0; i < 10; i++)
			{
				pw += Convert.ToString(rnd.Next(10));
			}
			return pw + "ruiker";
		}

		public new void logOutput()
		{
			Console.WriteLine(string.Format("gebruikersnaam: {0}, Login: {1}, wachtwoord: {2}", Gebruikersnaam, Login, wachtwoord));
		}

		protected string CreatePasswordHash(string pwd, string salt)
		{
			string saltAndPwd = String.Concat(pwd, salt);
			string hashedPwd = GetHashString(saltAndPwd);
			var saltPosition = 5;
			hashedPwd = hashedPwd.Insert(saltPosition, salt);
			return hashedPwd;
		}

		protected string CreateSalt()
		{
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] buff = new byte[10];
			rng.GetBytes(buff);
			var saltSize = 1;
			string salt = Convert.ToBase64String(buff);
			if (salt.Length > saltSize)
			{
				salt = salt.Substring(0, saltSize);
				return salt.ToUpper();
			}

			var saltChar = '^';
			salt = salt.PadRight(saltSize, saltChar);
			return salt.ToUpper();
		}

		protected string GetHashString(string wachtwoord)
		{
			StringBuilder sb = new StringBuilder();
			foreach (byte b in GetHash(wachtwoord))
				sb.Append(b.ToString("X2"));
			return sb.ToString();
		}

		public static byte[] GetHash(string inputString)
		{
			HashAlgorithm algorithm = SHA256.Create();
			return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
		}
	}
=======
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace Opdracht6
{
	class Gebruiker : Persoon1
	{
		protected string gebruikersnaam;
		protected string wachtwoord;
		protected string login;

		protected Random rnd = new Random();

		public string Gebruikersnaam
		{
			get { return this.gebruikersnaam; }
		}

		public string Wachtwoord
		{
			get { return this.wachtwoord; }
		}

		public string Login
		{
			get { return this.login; }
		}

		public Gebruiker(string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht)
		{
			this.wachtwoord = CreatePasswordHash(GeneratePassword(), CreateSalt());
			this.gebruikersnaam = GenerateUsername();
			this.login = GenerateLogin();
		}

		public Gebruiker(string voornaam, string familienaam, char geslacht, string username, string login, string password) : base(voornaam, familienaam, geslacht)
		{
			this.gebruikersnaam = username;
			this.login = login;
			this.wachtwoord = CreatePasswordHash(password, CreateSalt());
		}

		private string GenerateUsername()
		{
			return voornaam + Familienaam;
		}

		private string GenerateLogin()
		{
			return voornaam + Familienaam + "@gebruikers.com";
		}

		protected string GeneratePassword()
		{
			string pw = "Use";
			for (int i = 0; i < 10; i++)
			{
				pw += Convert.ToString(rnd.Next(10));
			}
			return pw + "ruiker";
		}

		public new void logOutput()
		{
			Console.WriteLine(string.Format("gebruikersnaam: {0}, Login: {1}, wachtwoord: {2}", Gebruikersnaam, Login, wachtwoord));
		}

		protected string CreatePasswordHash(string pwd, string salt)
		{
			string saltAndPwd = String.Concat(pwd, salt);
			string hashedPwd = GetHashString(saltAndPwd);
			var saltPosition = 5;
			hashedPwd = hashedPwd.Insert(saltPosition, salt);
			return hashedPwd;
		}

		protected string CreateSalt()
		{
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] buff = new byte[10];
			rng.GetBytes(buff);
			var saltSize = 1;
			string salt = Convert.ToBase64String(buff);
			if (salt.Length > saltSize)
			{
				salt = salt.Substring(0, saltSize);
				return salt.ToUpper();
			}

			var saltChar = '^';
			salt = salt.PadRight(saltSize, saltChar);
			return salt.ToUpper();
		}

		protected string GetHashString(string wachtwoord)
		{
			StringBuilder sb = new StringBuilder();
			foreach (byte b in GetHash(wachtwoord))
				sb.Append(b.ToString("X2"));
			return sb.ToString();
		}

		public static byte[] GetHash(string inputString)
		{
			HashAlgorithm algorithm = SHA256.Create();
			return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
		}
	}
>>>>>>> 5336f64b0c9d42cf5fad7ad1aa2e422af8863f8f
}