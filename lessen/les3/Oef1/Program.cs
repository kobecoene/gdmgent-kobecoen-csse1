using System;

namespace lessen
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            getal = 5; //initialisatie van variabele getal met de waarde 5
            /*
            Wat gaat er verder gebeuren in de code...
             */
            Console.WriteLine("Geef een getal in tussen 0-10");
            getal = Convert.ToInt32(Console.ReadLine());

            if (getal < 8)
            {
                Console.WriteLine("De waarde van het getal is: " + getal);
            }
            else if (getal > 6)
            {

            }
            else
            {

            }

            /*  if (getal < 8)
                 Console.WriteLine(getal + 1);
             else if (getal > 6)
                 Console.WriteLine(getal + 1);
             else if (getal >= 7)
                 Console.WriteLine("De waarden van het getal is:" + getal);
*/
            switch (getal)
            {
                case 7:
                    Console.WriteLine("Het getal in dit geval is  (case 7) " + getal);
                    break;

                default:
                    Console.WriteLine("In alle andere gevallen: " + getal);
                    break;
            }

            int teller = 5;
            for (int i = 0; i < teller; i++)
            {
                Console.WriteLine(i);
            }
            // Console.WriteLine("test");
        }
    }
}
