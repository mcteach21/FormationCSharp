using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBanque.banque
{
    abstract class Compte
    {
        static int cpteur = 1000;

        private int numero;
        private decimal solde;
        private string proprietaire;
        private List<Operation> historique;

        public Compte(decimal solde, string proprietaire)
        {
            Solde = solde<0?0:solde; 
            Proprietaire = proprietaire ?? throw new ArgumentNullException(nameof(proprietaire));

            historique = new List<Operation>();
            numero = cpteur++;
        }


        public int Numero { get => numero; }
        public decimal Solde { get => solde; set => solde = value; }
        public string Proprietaire { get => proprietaire; set => proprietaire = value; }
        internal List<Operation> Historique { get => historique; }


        //traitements : credit+debit+résumé

        public bool Crediter(decimal somme)
        {
            if (somme > 0)
            {
                this.solde += somme;
                this.historique.Add(new Operation(somme, "crédit..", Sens.Credit));
                return true;
            }
            return false;
        }
        public bool Crediter(decimal somme, Compte compte_a_debiter)
        {
            if (compte_a_debiter.Debiter(somme))
            {
                //this.solde += somme;
                //this.historique.Add(new Operation(somme, "crédit..", Sens.Credit));
                //return true;
                return Crediter(somme);
            }
            Console.WriteLine($"{this} : Opération crédit non effectuée! (débit impossible).");
            return false;
        }

        protected abstract bool DebitPossible(decimal somme);
        public bool Debiter(decimal somme)
        {
            if (DebitPossible(somme))
            {
                //faire débit..
                this.solde -= somme;
                this.historique.Add(new Operation(somme, "débit..", Sens.Debit));
                return true;
            }
            Console.WriteLine($"{this} : Opération débit non effectuée!");
            return false;
        }
        public bool Debiter(decimal somme, Compte compte_a_crediter)
        {
           //faire virement..
           return compte_a_crediter.Crediter(somme, this);
        }

        public override string ToString() =>  $"{numero} - {proprietaire} : {solde}€.";

        protected abstract string MyName(); //Nom renvoyé par classe dérivée!

        public void Resume()
        {
            string name = MyName(); //this.GetType().Name.Equals("CompteCourant") ? "Compte Courant" : "Compte Epargne";

            Console.WriteLine("*******************************");
            Console.WriteLine($"{name} numéro : {Numero}.");
            Console.WriteLine($"Propriétaire : { Proprietaire}, Solde : {Solde}€.");

            if (historique.Count == 0)
                Console.WriteLine("Aucune opération effectuée sur le compte.");
            else
            {
                Console.WriteLine("Historique opérations :");
                foreach (var operation in historique)
                    Console.WriteLine(operation);
            }

            Console.WriteLine("*******************************");
        }
    }
}
