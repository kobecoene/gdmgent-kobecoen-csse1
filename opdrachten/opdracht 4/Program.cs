using System;

namespace opdracht_4
{
    class Program
    {
        static void Add(int getal1, int getal2){
           Console.WriteLine("Optellen");
           int result = getal1 + getal2;
           Console.WriteLine(result);
       }
       static void Subtrack(int getal1, int getal2){
           Console.WriteLine("Aftrekken");
           int result2 = getal1 - getal2;
           Console.WriteLine(result2);
       }
       static void Multiply(int getal1, int getal2){
           Console.WriteLine("Vermenigvuldigen");
           int result3 = getal1 * getal2;
           Console.WriteLine(result3);
       }
       static void Devide(int getal1, int getal2){
           Console.WriteLine("Delen");
           double result4 = (double) getal1 / getal2;
           Console.WriteLine(result4);
       }

       static void Main(string[] args){
           Add(8,3);
           Subtrack(8,3);
           Multiply(8,3);
           Devide(8,3);
       }

    }
}
