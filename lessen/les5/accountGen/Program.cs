using System;

namespace accountGen
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
            SchrijfLog(args.Length);
            SchrijfLog(args[0]);
            }
            catch(System.IndexOutOfRangeException){
                SchrijfLog("De collectie is ledig");
            }
            catch (System.Exception)
            {
                SchrijfLog("Er is een probleem");
                throw;
            }
            


            Console.WriteLine("Registratie van een student...");
            SchrijfLog("Geef de voornaam in van de student:");
            string voornaam = Console.ReadLine();
            SchrijfLog("Geef de naam in van de student: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Aanmaak van het account van een student");
            SchrijfLog(genereerAccount(voornaam,naam));
        }

        static string genereerAccount(string Voornaam, 
                                      string achternaam){
                return string.Format("De account van {0} {1} is: {2}", Voornaam, achternaam, 
                                    genereerString(Voornaam.ToLower(), 4)+ genereerString(achternaam.ToLower(),4));
        }
        static string genereerString(string input, int lengte){
            return input.Substring(0,lengte);
        }
        static void SchrijfLog(string output) => Console.WriteLine(output);
        static void SchrijfLog(int output) => Console.WriteLine(output.ToString());
    }

}
