using System;
using System.Text;
using System.Threading;

namespace opdarcht_5
{
	class Program
	{
		static void Main(string[] args)
		{
			//rekenmachine
			SchrijfLog(Som(5, 6));
			SchrijfLog(Verschil(8, 5));
			SchrijfLog(Quotient(8, 4));
			SchrijfLog(Product(5, 3));
			SchrijfLog(Modulo(9, 2));
			SchrijfLog(Verhogen(2));
			SchrijfLog(Verlagen(2));
			SchrijfLog(Willekeurig());
			SchrijfLog("Willekeurig getal met bereik... \n" + WillekeurigBereik(0, 80));

			//Lottotrekking
			SchrijfLog(genereerLottoGetallen());
			lottoTrekking();

			SchrijfLog(genereerEuroMilGetallen());
			euroMilTrekking();

			//accountgenerator
			try
			{
				SchrijfLog(args.Length);
				SchrijfLog(args[0]);
			}
			catch (System.IndexOutOfRangeException)
			{
				SchrijfLog("De collectie is ledig");
			}
			catch (System.Exception)
			{
				SchrijfLog("Er is een probleem");
				throw;
			}
			Console.WriteLine("Student of Docent: ");
			string type = Console.ReadLine().ToLower();

			if (type == "student")
			{
				Console.WriteLine("Registratie van een student...");
				SchrijfLog("Geef de voornaam in van de student:");
				string voornaam = Console.ReadLine();
				SchrijfLog("Geef de naam in van de student: ");
				string naam = Console.ReadLine();
				Console.WriteLine("Aanmaak van het account van een student");
				SchrijfLog(genereerStudent(voornaam, naam));
			}
			else
			if (type == "docent")
			{
				Console.WriteLine("Registratie van een docent...");
				SchrijfLog("Geef de voornaam in van de docent:");
				string voornaam = Console.ReadLine();
				SchrijfLog("Geef de naam in van de docent: ");
				string naam = Console.ReadLine();
				Console.WriteLine("Aanmaak van het account van een docent");
				SchrijfLog(genereerDocent(voornaam, naam));
			}
			else
			{
				Console.WriteLine("Geef docent of student in");
			}

			//IBAN checker
			Console.WriteLine("Geef uw IBAN nummer in:");
			string ibanNr = Console.ReadLine();

			if (ValidateBankAccount(ibanNr))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}

			// Faculteit
			Console.WriteLine("Geef uw nummer in waarvan je de faculeit van wilt: ");
			int inputFac = Convert.ToInt32(Console.ReadLine());
			int factorial = 1;
			for (int i = 1; i <= inputFac; i++)
			{
				factorial *= i;
			}
			Console.WriteLine("De faculteit van " + inputFac + " is: " + factorial);

			// Fibonacci
			int nummer1 = 0;
			int nummer2 = 1;
			int nummer3;
			int inputFib;
			Console.Write("Hoeveel tekens moeten er getoont worden? ");
			inputFib = Convert.ToInt32(Console.ReadLine());
			Console.Write(nummer1 + " " + nummer2 + " "); //printing 0 and 1    
			for (int i = 2; i < inputFib; ++i) //loop starts from 2 because 0 and 1 are already printed    
			{
				nummer3 = nummer1 + nummer2;
				Console.Write(nummer3 + " ");
				nummer1 = nummer2;
				nummer2 = nummer3;
			}
		}

		//som
		static int Som(int getal1, int getal2)
		{
			SchrijfLog("Som...");
			return getal1 + getal2;
		}
		//verschil
		static int Verschil(int getal1, int getal2)
		{
			SchrijfLog("Verschil...");
			return getal1 - getal2;
		}

		//Quotient
		static int Quotient(int getal1, int getal2)
		{
			SchrijfLog("Quotient...");
			return getal1 / getal2;
		}

		// product
		static int Product(int getal1, int getal2)
		{
			SchrijfLog("Product...");
			return getal1 * getal2;
		}

		//modulo
		static int Modulo(int getal1, int getal2)
		{
			SchrijfLog("Modulo...");
			return getal1 % getal2;
		}

		// Verhogen
		static int Verhogen(int getal)
		{
			SchrijfLog("Verhogen...");
			return ++getal;
		}

		// Verlagen  
		static int Verlagen(int getal)
		{
			SchrijfLog("Verlagen...");
			return --getal;
		}

		// Willekeurig
		static int Willekeurig()
		{
			SchrijfLog("Willekeurig getal...");
			Random r = new Random();
			int num = r.Next();
			return num;
		}

		// WillekeurigBE07 7390 1412 0066reik
		static int WillekeurigBereik(int getal1, int getal2)
		{

			Random r = new Random();
			int randomNbr = r.Next(getal1, getal2);
			return randomNbr;

		}

		//lotto
		static string genereerLottoGetallen()
		{
			string output = "";
			for (int i = 0; i < 6; i++)
			{
				output += " " + WillekeurigBereik(1, 45);
			}
			return output;
		}
		static void lottoTrekking()
		{

			SchrijfLog("Lottotrekking");
			for (int i = 0; i < 6; i++)
			{

				SchrijfLog(WillekeurigBereik(1, 45));
				Thread.Sleep(5000);
			}
		}

		//euromillions
		static string genereerEuroMilGetallen()
		{
			string output = "";

			SchrijfLog("Getallen en sterren");
			for (int i = 0; i < 5; i++)
			{
				output += " " + WillekeurigBereik(1, 50);
			}

			for (int j = 0; j < 2; j++)
			{
				output += " " + WillekeurigBereik(1, 12);
			}
			return output;
		}

		static void euroMilTrekking()
		{

			SchrijfLog("Euro Millions Trekking");

			SchrijfLog("De getallen zijn: ");
			for (int i = 0; i < 5; i++)
			{
				SchrijfLog(WillekeurigBereik(1, 50));
				Thread.Sleep(2000);
			}

			SchrijfLog("De sterren zijn");
			for (int i = 0; i < 2; i++)
			{
				SchrijfLog(WillekeurigBereik(1, 12));
				Thread.Sleep(2000);
			}
		}

		//account generator
		static string genereerDocent(string Voornaam,
									  string achternaam)
		{
			return string.Format("De account van {0} {1} is: {2}", Voornaam, achternaam,
								genereerString(Voornaam.ToLower(), 4) + genereerString(achternaam.ToLower(), 2) + "@arteveldehs.be");
		}
		static string genereerStudent(string Voornaam,
									  string achternaam)
		{
			return string.Format("De account van {0} {1} is: {2}", Voornaam, achternaam,
								genereerString(Voornaam.ToLower(), 4) + genereerString(achternaam.ToLower(), 4) + "@student.arteveldehs.be");
		}

		//IBAN checker

		public static bool ValidateBankAccount(string ibanNr)
		{
			ibanNr = ibanNr.ToUpper();
			if (String.IsNullOrEmpty(ibanNr))
				return false;
			else if (System.Text.RegularExpressions.Regex.IsMatch(ibanNr, "^[A-Z0-9]"))
			{
				ibanNr = ibanNr.Replace(" ", String.Empty);
				string bank =
				ibanNr.Substring(4, ibanNr.Length - 4) + ibanNr.Substring(0, 4);
				int asciiShift = 55;
				StringBuilder sb = new StringBuilder();
				foreach (char c in bank)
				{
					int v;
					if (Char.IsLetter(c)) v = c - asciiShift;
					else v = int.Parse(c.ToString());
					sb.Append(v);
				}
				string checkSumString = sb.ToString();
				int checksum = int.Parse(checkSumString.Substring(0, 1));
				for (int i = 1; i < checkSumString.Length; i++)
				{
					int v = int.Parse(checkSumString.Substring(i, 1));
					checksum *= 10;
					checksum += v;
					checksum %= 97;
				}
				return checksum == 1;
			}
			else
				return false;
		}
		static string genereerString(string input, int lengte)
		{
			return input.Substring(0, lengte);
		}

		static void SchrijfLog(string output) => Console.WriteLine(output);
		static void SchrijfLog(int output) => Console.WriteLine(output.ToString());
	}
}
