using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBanque.banque
{
    class CompteEpargne : Compte
    {
        private decimal taux_abondement;

        public CompteEpargne(decimal solde, string proprietaire, decimal taux_abondement) 
            : base(solde, proprietaire)
        {
            Taux_abondement = taux_abondement;
        }

        public decimal Taux_abondement { 
            get => taux_abondement; 
            set => taux_abondement = value>=0?value:0;
        }

        protected override bool DebitPossible(decimal somme) => this.Solde >= somme;

        protected override string MyName()
        {
            return "Compte Epargne";
        }
    }

}
