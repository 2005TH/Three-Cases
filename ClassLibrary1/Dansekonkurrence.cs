using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ClassLibrary1
{
    public class Dansekonkurrence
    {
        public void Dans(bool debug)
        {
            Output op = new Output();

            //Brugeren får nogle nye spørgsmål som der skal svares på
            op.Printline(debug, "Velkommen til dansekonkurrencen\n\nHvad hedder den første danser?:  ");
            string Danser1 = Console.ReadLine();
            op.Printline(debug, "\nMellem 1-10, hvilken scorer fik " + Danser1 + " så:  ");
            int Danser1Score = Convert.ToInt32(Console.ReadLine());

            op.Printline(debug, "\nHvad hedder den anden danser?:  ");
            string Danser2 = Console.ReadLine();
            op.Printline(debug, "\nMellem 1-10, hvilken scorer fik " + Danser2 + " så:  ");
            int Danser2Score = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            //Brugeren får svar udfra det der er blevet svaret i de ovre spørgsmål
            op.Printline(debug, "Danseren med den største score er\n");
            if (Danser1Score > Danser2Score)
            {
                op.Printline(debug, Danser1 + " med " + Danser1Score + "\nPå andenpladsen er " + Danser2 + " med " + Danser2Score);
            }
            if (Danser2Score > Danser1Score)
            {
                op.Printline(debug, Danser2 + " med " + Danser2Score + "\nPå andenpladsen er " + Danser1 + " med " + Danser1Score);
            }
            if (Danser1Score == Danser2Score)
            {
                op.Printline(debug, Danser1 + " og " + Danser2 + " havde begge en score på " + Danser1Score);
            }

            //når brugeren har fået svar, bliver de sendt tilbage til menuen
            op.Printline(debug, "\nTryk på en tast for at komme tilbage til menuen");
            Console.ReadKey();
            Menu nyMenu = new Menu();
            nyMenu.Pick(debug);

        }

    }
}
