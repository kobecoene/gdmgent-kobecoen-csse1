using System;
using System.Threading;

namespace les5
{
    class Program
    {
        static void Main(string[] args)
        {
        
            SchrijfLog(GenereerWillekeurigGetal());
            SchrijfLog(GenereerWillekeurigGetal(1,45));

            SchrijfLog(genereerLottoGetallen());
            lottoTrekking();

            SchrijfLog(genereerEuroMilGetallen());
            euroMilTrekking();
        }
        static void SchrijfLog(string output) => Console.WriteLine(output);
        static void SchrijfLog(int output) => Console.WriteLine(output.ToString());

        static int GenereerWillekeurigGetal(){
            Random r = new Random();
           return r.Next();
        }
        static int GenereerWillekeurigGetal(int min, int max){
            Random r = new Random();
            return r.Next(min,max);
        }
        static string genereerLottoGetallen(){
            string output = "";
            for (int i =0; i <6; i++){
                output += " " +  GenereerWillekeurigGetal(1,45);
            }
            return output;
        }

        static void lottoTrekking(){

            SchrijfLog("Lottotrekking");
            for (int i =0; i <6; i++){
                
               SchrijfLog(GenereerWillekeurigGetal(1,45)); 
               Thread.Sleep(5000);                
            }
        }

        static string genereerEuroMilGetallen(){
            string output = "";

            SchrijfLog("Getallen en sterren");
            for (int i =0; i <5; i++){
                output += " " +  GenereerWillekeurigGetal(1,50);
            }

            for (int j =0; j <2; j++){
                output += " " +  GenereerWillekeurigGetal(1,12);
            }
            
            return output;
        }

        static void euroMilTrekking(){

            SchrijfLog("Euro Millions Trekking");

            SchrijfLog("De getallen zijn: ");
            for (int i =0; i <5; i++){
               SchrijfLog(GenereerWillekeurigGetal(1,50)); 
               Thread.Sleep(2000);                
            }

            SchrijfLog("De sterren zijn");
            for (int i =0; i <2; i++){ 
               SchrijfLog(GenereerWillekeurigGetal(1,12)); 
               Thread.Sleep(2000);                
            }
        }
    }
}
