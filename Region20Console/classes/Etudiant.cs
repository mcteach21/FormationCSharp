using System;
using System.Collections.Generic;
using System.Text;

namespace Region20Console.classes
{
    /**
     * classe heritant de Personne
     */
    class Etudiant : Personne
    {
        private string formation;
        private DateTime date_entree;

        public Etudiant(string nom, string prenom, DateTime date_Naissance, string formation, DateTime date_entree) 
            : base(nom, prenom, date_Naissance)
        {
            this.Formation = formation;
            this.Date_entree = date_entree;
        }

        public string Formation { get => formation; set => formation = value; }
        public DateTime Date_entree { get => date_entree; set => date_entree = value; }


        public new void Afficher() // new : masquer explicitement la methode heritée equivalente!
        {
            base.Afficher();
            Console.WriteLine($"Je suis un etudiant en '{Formation}'.");
        }
    }
}
