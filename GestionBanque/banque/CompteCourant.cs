using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBanque.banque
{
    class CompteCourant : Compte
    {
        private decimal decouvert_autorise;

        public CompteCourant(decimal solde, string proprietaire, decimal decouvert_autorise) 
            : base(solde, proprietaire)
        {
            Decouvert_auitorise = decouvert_autorise;
        }

        public decimal Decouvert_auitorise { 
            get => decouvert_autorise; 
            set => decouvert_autorise = value>=0?value:0; 
        }

        protected override bool DebitPossible(decimal somme) => this.Solde+this.decouvert_autorise >= somme;

        protected override string MyName()
        {
            return "Compte Courant";
        }
    }
}
