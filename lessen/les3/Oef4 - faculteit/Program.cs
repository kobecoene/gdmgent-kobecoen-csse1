using System;

namespace Oef4___faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw nummer in waarvan je de faculeit van wilt: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("De faculteit van " + input + " is: " + factorial);
        }
    }
}
