using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;

namespace ClassLibrary1
{
    public class BrugerOpret
    {
        public void Opret(bool debug)
        {
            BrugerOpret nyBrugerOpret = new BrugerOpret();
            BrugerLogin nyBrugerLogin = new BrugerLogin();

            Output op = new Output();

            //Scærmen bliver cleared og brugeren bliver stilt et nyt spørgsål
            Console.Clear();
            op.Printline(debug, "Har du allerede en bruger?(ja/nej)");
            string jaellernej = Console.ReadLine().ToLower();

            //Hvis bruger svare ja bliver han sendt direkte til der hvor han kan logge ind
            if (jaellernej == "ja")
            {
                nyBrugerLogin.Login(debug);
            }
            //Hvis brugeren siger nej, så skal have oprette sig med et brugernavn, og kode som skal laves på en speciel måde
            if (jaellernej == "nej")
            {
                Console.Clear();

                op.Printline(debug, "Opret en bruger\n");

                op.Printline(debug, "Brugernavn:   ");
                string Brugernavn = Console.ReadLine();

                op.Printline(debug, "Password:     ");
                string Password = Console.ReadLine();

                bool holdertal = Password.Any(char.IsDigit);
                bool holderlower = Password.Any(char.IsLower);
                bool holderupper = Password.Any(char.IsUpper);
                bool holdersymbol = Regex.IsMatch(Password, @"[!@#$%^&*(),.?:{ }|<>]");
                bool holderlængde = Password.Length >= 12;

                // Disse bool bliver sande hvis de opfylder kravende, men det skal de ikke så de bliver brugt med "!" foran
                bool starttal = char.IsDigit(Password[0]);
                bool sluttal = char.IsDigit(Password[Password.Length - 1]);


                //Hvis kravende er bliver opfyldt så går den videre med at lave en fil
                if (holdertal && holderlower && holderupper && holdersymbol && holderlængde && !starttal && !sluttal)
                {
                    string linje = Brugernavn + " " + Password;
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\thohol\Desktop\ThreeCases brugerpassword.txt", true))
                    {
                        file.WriteLine(linje);
                    }
                    nyBrugerLogin.Login(debug);
                }
                //Hvis de ikke er opfyldt så fortæller den der er noget galt og går tilbage til 
                else if (!holdertal || !holderlower || !holderupper || !holdersymbol || !holderlængde || starttal || sluttal)
                {
                    Console.Clear();
                    op.Printline(debug, "Koden skal indholde, store og små bogstaver, symbolder og tal, den skal også være mindst 12 bogstaver lang");
                    Console.ReadKey();
                    nyBrugerOpret.Opret(debug);
                }


            }
            else
            {
                //Hvis brugeren svare andet end ja og nej så bliver de smidt tilbage op til starten
                Console.Clear();
                op.Printline(debug, "Du kan kun skrive \"ja\" eller \"nej\"");
                Console.ReadKey();
                nyBrugerOpret.Opret(debug);
            }
        }

    }
}
