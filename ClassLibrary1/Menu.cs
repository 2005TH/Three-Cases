using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ClassLibrary1
{
    public class Menu
    {
        public void Pick(bool debug)
        {
            Output op = new Output();
            Console.Clear();

            //Brugeren får nogle valgmuligheder
            op.Printline(debug, "Hvilket program vil du køre?\n");
            op.Printline(debug, "Tryk 1 for fodbold");
            op.Printline(debug, "Tryk 2 for dansekonkurrence\n");
            string vælgMenu = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
            Console.Clear();

            //Brugeren bliver sendt til et program udfra hvad de svare
            switch (vælgMenu)
            {
                case "1":
                    Console.Clear();
                    FodboldKlub nyFodbold = new FodboldKlub();
                    nyFodbold.Fodbold(debug);
                    break;

            
                case "2":
                    Console.Clear();
                    Dansekonkurrence nyDansekonkurrence = new Dansekonkurrence();
                    nyDansekonkurrence.Dans(debug);
                    break;

                //Hvis brugeren taster noget forkert bliver de sendt up til toppen
                default:
                op.Printline(debug, "Forkert input prøv igen\nDu kan vælge i mellem 1 og 2\n\nTryk på en tast for at prøve igen");
                Console.ReadKey();
                Menu nyMenu = new Menu();
                nyMenu.Pick(debug);
                    break ;
            }
           

        }

        

    }

    public class Output
    {
        //Metode for debug 
        public void Printline(bool debug, string print)
        {
            //Hvis en er true så skriver den dette
            if (debug)
            {
                System.Diagnostics.Debug.WriteLine(print);
            }
            //Hvis debug er false så skriver den Write hvis der er : hvis ikke så laver den en normal writeline
            else
            {
                if (print.Contains(":"))
                {
                    Console.Write($"{print} ");
                }
                else
                {
                    Console.WriteLine(print);
                }
            }
        }
    }

}
