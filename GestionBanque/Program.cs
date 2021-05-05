using GestionBanque.banque;
using System;

namespace GestionBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine($"{DateTime.Now.ToString("dd MMMM yyyy")} : Gestion Banque!");
            Console.WriteLine("**********************************");

            Compte c1 = new CompteCourant(100, "Nicolas", 2000);
            Compte c2 = new CompteEpargne(20, "Nicolas", (decimal)0.02);

            c1.Resume();
            c2.Resume();

            c1.Crediter(100);
            c1.Debiter(50);

            c2.Crediter(20, c1);
            c2.Crediter(100);

            c2.Debiter(20, c1);

            c1.Resume();
            c2.Resume();

            c1.Crediter(5000, c2);
        }
    }
}
