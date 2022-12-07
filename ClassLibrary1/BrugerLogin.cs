using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassLibrary1
{
    public class BrugerLogin
    {
        public void Login(bool debug)
        {
            Output op = new Output();
            String BrugerNavn, Password;
            
            Console.Clear();

            //Brugeren skal give et brugernavn og password til at logge ind
            op.Printline(debug, "Login\n");
            op.Printline(debug, "Brugernavn:   ");
            BrugerNavn = Console.ReadLine();
            op.Printline(debug, "Password:     ");
            Password = Console.ReadLine();
            
            //programmen finder ud af her hvilken fil den skal kigge i
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\thohol\Desktop\ThreeCases brugerpassword.txt");

            //Her tjekker den om Brugernavnet og password er gyldigt, og om password passer til det rigtige brugernavn
            foreach (string line in lines)
            {
                if (line.Contains(BrugerNavn) && line.Contains(Password))
                {
                    //Brugeren får noget information
                    Console.Clear();
                    op.Printline(debug, "Du er nu logged ind");
                    op.Printline(debug, "Tryk på en tast for at fortsætte");
                    Console.ReadKey();
                    Menu nyMenu = new Menu();
                    nyMenu.Pick(debug);
                }
                
            }
                //Hvis brugeren skriver noget forkert, bliver de smidt tilbage til bruger oprettelse 
                Console.Clear();
                op.Printline(debug, "Brugernavn eller password er forkert\nTryk på en tast for at prøve igen");
                Console.ReadKey();
                BrugerOpret nyBrugerLogin = new BrugerOpret();
                nyBrugerLogin.Opret(debug);
            
        }
    }
}
