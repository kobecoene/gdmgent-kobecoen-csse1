using System;

namespace Oef5___fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer1 = 0;
            int nummer2 = 1;
            int nummer3;
            int input;
            Console.Write("Hoeveel tekens moeten er getoont worden? ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.Write(nummer1 + " " + nummer2 + " "); //printing 0 and 1    
            for (int i = 2; i < input; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                nummer3 = nummer1 + nummer2;
                Console.Write(nummer3 + " ");
                nummer1 = nummer2;
                nummer2 = nummer3;
            }
        }
    }
}
