using System;
using System.Collections.Generic;
using System.Text;

namespace Region20Console.classes
{
    class Personne
    {
        private static int cpteur = 0; //pour définir valeur de Id!

        //encapsulation
        private int id;
        private string nom;
        private string prenom;
        //private DateTime date_naissance;
        //propriétés : getters + setters
        public int Id {
            //get { 
            //    return this.id;
            //}
            //set {
            //    this.id = value;
            //}
            get => id;
            //set => id = value;
        }
        public string Nom { get => nom; set => nom = (value==null)?"?":value; }
        public string Prenom { get => prenom; set => prenom = value; }

        //public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }
        public DateTime Date_Naissance { get; set; } //attribue date_naissance 'implicite'

        public Personne(string nom, string prenom, DateTime date_Naissance)
        {
            this.id = ++cpteur;          
            Nom = nom;
            Prenom = prenom;
            Date_Naissance = date_Naissance;
        }

        //this(...) : appel du constructeur
        public Personne(string nom, string prenom) : this( nom, prenom, new DateTime())
        {
            //autre traitement
        }

        public override string ToString()
        {
            return "["+Id+"] "+Prenom+" "+Nom;
        }

        //méthodes..
        public void Afficher()
        {
           Console.WriteLine($"Je m'appelle {Prenom} {Nom}, j'ai {calculAge()} ans.");
        }
        public void Afficher(string lang)
        {
            if ("fr".Equals(lang))
                Afficher();
            else
                Console.WriteLine($"My name i {Prenom} {Nom}, I'm {calculAge()} years old.");
        }

        private int calculAge() => DateTime.Now.Year - Date_Naissance.Year;



    }
}
