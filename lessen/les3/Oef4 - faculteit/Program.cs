using System;

namespace Oef4___faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;

            Console.Write("Enter any Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            Console.Write("Factorial of " + number + " is: " + fact);
        }
    }
}
