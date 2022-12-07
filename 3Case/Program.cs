using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace _3Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Output op = new Output();
           
            //Jeg får brugeren til at vælge mellem Debug eller standard
            bool debug;
            Console.WriteLine("[D] Debug    [S] Standard");
            string tast = Convert.ToString(Console.ReadKey().KeyChar).ToLower();

            //Debug bliver true eller false udfra hvad brugeren har svaret
            if(tast == "d")
            {
                debug = true;
            }
            else
            {
                debug = false;
            }

            //Når brugeren har svaret bliver han sendt vidre til brugeropretelse
            BrugerOpret nyBrugerLogin = new BrugerOpret();
            nyBrugerLogin.Opret(debug);
            

        }
    }
}
