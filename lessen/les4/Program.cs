using System;

namespace Les4
{
    class Program
    {
        static string globaleVariabele = "Output: ";
        int teller = 0;
        static int teller1 = 0;
        static void GenereerFib(int lengte)
        {
            Console.WriteLine(globaleVariabele + "Start Methode..., de lengte is: " + lengte);
        }

        static void GenereerFib(int lengte1, int lengte2)
        {
            Console.WriteLine(globaleVariabele + "Start Methode..., de lengte is: " + lengte1);
            Console.WriteLine(globaleVariabele + "Start Methode..., de lengte is: " + lengte2);
        }

        static string GenereerFibToString(int lengte1)
        {
            //Console.WriteLine(globaleVariabele + "Start Methode..., de lengte is: " + lengte1);
            //Console.WriteLine(globaleVariabele + "Start Methode..., de lengte is: " + lengte2);
            // String tekst = "";
            return "Start Methode... " + lengte1;
        }


        static void Main(string[] args)
        {
            globaleVariabele = "Output: ";
            int getal1 = 8;
            Console.WriteLine(globaleVariabele + "Hello World!");


            double fahr = 100;
            double cels = (fahr - 32) * (5.0/9.0);
            Console.WriteLine(globaleVariabele + cels);

            //Boolean test;
            //test = true;
            //Console.WriteLine(test.ToString());

//System.Int32 a = 32;
//Int32 b = 33;

            // Boolean
            Console.WriteLine(globaleVariabele + sizeof(System.Boolean).ToString());
            Console.WriteLine(globaleVariabele + sizeof(System.Int32).ToString());
            Console.WriteLine(globaleVariabele + sizeof(System.Int64).ToString());
            Console.WriteLine(globaleVariabele + System.Runtime.InteropServices.Marshal.SizeOf(new System.Boolean()));

            // Char in C#.
            /*
                Met deze regel code:
                    Maak je een char variabele met de naam a (declareren).
                    Ken je de waarde c toe aan de variabele a (initialiseren).
                De waarde c van een char‐variabele a, wordt altijd tussen 
                enkele aanhalingstekens geschreven!
             */
            //char a = 'c';
            //a = 'b';
            // Deze regel wijzigt de waarde van de variabele a naar de letter b.

            string mijnString = "Dit is mijn eerste regel tekst...";
            Console.WriteLine(globaleVariabele + mijnString);
            string mijnString2 = "Dit is mijn eerste\nregel tekst...";
            Console.WriteLine(globaleVariabele + mijnString2);

            // Declareer en initialiseer een string
            string mijnString3 = "hallo";
            string mijnString4 = "iedereen";
            // Samenvoegen van de string met een spatie tussen...
            string mijnString5 = mijnString3 + " " + mijnString4;
            // Het resultaat weergeven...
            Console.WriteLine(globaleVariabele + mijnString5);

            const double Interest = 0.80;
            double geld = 275.00;
            //int jaarRente = (int)geld * Interest + 1;
            //int jaarRente = (int)(geld * (Interest + 1))/100;
            double jaarRente = (geld * (Interest + 1))/100;
            Console.WriteLine("De jaarlijkse rente op een bedrag van: " + geld + " is na een jaar: " + jaarRente);

            // Voorbeelden met decimal waarden.
            int x = 14;
            int y = 8;
            int result1 = x + y; // result1 = 22
            int result2 = x - y; // result2 = 6
            int result3 = x * y; // result3 = 112
            int result4 = x / y; // result4 = 1
            int result5 = x % y; // result5 = 6
            int result6 = -y + x; // result6 = 6
            int result7 = --y; // result7 = 7
            int result8 = ++x; // result8 = 15, x = 15

            // Voorbeelden met decimal waarden.
            decimal a = 8.5m;
            decimal b = 3.4m;
            decimal result11 = a + b; // result11 = 11.9
            Console.WriteLine(globaleVariabele + "a + b: " + result11);
            decimal result12 = a - b; // result12 = 5.1
            decimal result13 = a / b; // result13 = 2.5
            decimal result14 = a * b; // result14 = 28.90
            decimal result15 = a % b; // result15 = 1.7
            Console.WriteLine(globaleVariabele + "a % b: " + result15);
            decimal result16 = -a; // result16 = -8.5
            decimal result17 = --a; // result17 = 7.5
            decimal result18 = ++b; // result18 = 4.4

            // Voorbeelden met char waarden
            char letter1 = 'C'; 
            // letter1 = 'C'
            // Unicode integer is 67
            char letter2 = ++letter1;

            Console.WriteLine(globaleVariabele + "letter2: " + letter2.ToString());
            // letter2 = 'D'
            // Unicode integer is 68

            //https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code

            GenereerFib(getal1);
            GenereerFib(getal1, getal1);
            //Voorbeeld1
            string returnFib = GenereerFibToString(getal1);
            Console.WriteLine(globaleVariabele + returnFib);
            //Voorbeeld 2
            Console.WriteLine(globaleVariabele + GenereerFibToString(getal1));            
        }
    }
}