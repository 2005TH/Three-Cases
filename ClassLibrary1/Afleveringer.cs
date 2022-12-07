using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassLibrary1
{
    public class Afleveringer
    {
        
        public void AntalAfleveringer(bool debug)
        {
            Output op = new Output();

            //Brugeren skal skrive antal afleveringer så brugeren kan få et svar udfra antallet
            Console.Clear();
            op.Printline(debug, "Hvor mange afleveringer er der blevet lavet?:");
            int Antal = Convert.ToInt32(Console.ReadLine());

            //Koden giver et forskelligt svar udfra det tal brugeren har skrevet
            if (Antal == 0)
            {
                op.Printline(debug, "Shh");
            }
            if (Antal >= 1 && Antal < 10)
            {
                string print = "";
                for (int i = 0; i < Antal; i++)
                {
                    print += "Huh! ";
                }
                op.Printline(debug, print);
            }
            if (Antal >= 10 && Antal <= 15)
            {
                op.Printline(debug, "High Five – Jubel");
            }
            if (Antal > 15 && Antal <= 20)
            {
                op.Printline(debug, "High Five – Jubel!");
            }
            if (Antal > 20 && Antal <= 25)
            {
                op.Printline(debug, "High Five – Jubel!!");
            }
            if (Antal > 25)
            {
                op.Printline(debug, "High Five – Jubel!!!");
            }

            //brugeren får noget info og bliver smidt tilbage til menuen
            op.Printline(debug, "\nTryk på en tast for at komme tilbage til menuen");
            Console.ReadKey();
            Menu nyMenu = new Menu();
            nyMenu.Pick(debug);

        }
    }
}
