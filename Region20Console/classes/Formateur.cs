using System;
using System.Collections.Generic;
using System.Text;

namespace Region20Console.classes
{
    class Formateur : Personne
    {
        private string specialite;
        private DateTime date_embauche;

        public Formateur(string nom, string prenom, DateTime date_Naissance, string specialite, DateTime date_embauche) 
            : base(nom, prenom, date_Naissance)
        {
            this.Date_embauche = date_embauche;
            this.Specialite = specialite;
        }
        public string Specialite { get => specialite.ToUpper(); set => specialite = value; }
        public DateTime Date_embauche { get => date_embauche; set => date_embauche = value; }

        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Je suis formateur, spécialisé en {Specialite}.");
        }
    }
}
