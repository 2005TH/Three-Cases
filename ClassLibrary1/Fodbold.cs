using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ClassLibrary1
{
    public class FodboldKlub
    {

        public string[] CheckM = { "M", "m" };
        public string[] CheckÅ = { "Å", "å" };
        public string[] CheckL = { "L", "l" };
        public void Fodbold(bool debug)
        {
            Output op = new Output();

            //Brugeren bliver stilt nogen nye spørgsmål
            Console.Clear();
            op.Printline(debug, "Hvor mange afleveringer er der blevet lavet?:");
            int Antal = Convert.ToInt32(Console.ReadLine());
            op.Printline(debug, "Skriv mål hvis der har været mål, ellers skriv nej:");
            string Mål = Console.ReadLine();

            //Brugerens svar bliver tjekket igennem og bliver sendt forskellige steder, udfra hvad brugeren svare
            if (Mål.Length > 3 || Mål.Length < 3)
            {
                Console.Clear();
                op.Printline(debug, "Du må ikke skrive mål med mere eller mindre end 3 bogstaver\n\nTryk på en tast for at prøve igen");
                Console.ReadKey();
                FodboldKlub nyFodbold = new FodboldKlub();
                nyFodbold.Fodbold(debug);
            }
            if (Mål.Contains(CheckM[0]) | Mål.Contains(CheckM[1]) && Mål.Contains(CheckÅ[0]) | Mål.Contains(CheckÅ[1]) && Mål.Contains(CheckL[0]) | Mål.Contains(CheckL[1]))
            {
                Console.Clear();
                Mål nyMÅL = new Mål();
                nyMÅL.ScoredMål(debug);
            }
            else
            {
                Afleveringer nyAflevernger = new Afleveringer();
                nyAflevernger.AntalAfleveringer(debug);
            }
            
        }

    }
}
