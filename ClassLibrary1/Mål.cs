using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassLibrary1
{
    public class Mål
    {
        public void ScoredMål(bool debug)
        {
            Output op = new Output();

            //Hvis der har været mål, vil programmet svare "Olé olé olé" og sende en tilbage til menuen
            op.Printline(debug, "Olé olé olé");
            op.Printline(debug, "\nTryk på en tast for at komme tilbage til menuen");
            Console.ReadKey(); Menu nyMenu = new Menu();
            nyMenu.Pick(debug);
        }
    }
}
