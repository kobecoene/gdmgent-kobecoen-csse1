using System;

namespace Oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening a --> tafels van 5
            // int tafel = 5;
            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine(i + " x " + tafel + " = " + tafel * i);
            // }


            //oefening b --> alle tafels
            // for (int i = 0; i <= 10; i++)
            // {
            //     for (int j = 0; j <= 10; j++)
            //     {
            //         Console.WriteLine(j + " x " + i + " = " + i * j);
            //     }
            // }
            //Oefening c --> geef een getal in waarvan je de tafel wilt
            Console.WriteLine("Geef een getal in waarvan de tafel van wil uitgewerkt zien: ");
            int specifiekeTafel = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + specifiekeTafel + " = " + i * specifiekeTafel);
            }
        }
    }
}
