using System;
using System.Collections.Generic;
using System.Text;

namespace Region20WinForms.model
{
    class User
    {
        static int cpt = 0;

        private int id;
        private string prenom;
        private string nom;
        private string adresse;
        private bool homme;
        private List<string> competences;

        public int Id { get => id; set => id = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public bool Homme { get => homme; set => homme = value; }
        public List<string> Competences { get => competences; set => competences = value; }

        public User()
        {
        }

        public User(string prenom, string nom, string adresse, bool homme, List<string> competences)
        {
            Id = ++cpt;
            Prenom = prenom ?? throw new ArgumentNullException(nameof(prenom));
            Nom = nom ?? throw new ArgumentNullException(nameof(nom));
            Adresse = adresse ?? throw new ArgumentNullException(nameof(adresse));
            Homme = homme;
            Competences = competences ?? throw new ArgumentNullException(nameof(competences));
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom}";
        }
    }
}
