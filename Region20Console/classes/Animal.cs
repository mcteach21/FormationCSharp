using System;
using System.Collections.Generic;
using System.Text;

namespace Region20Console.classes
{
    abstract class Animal //classe abstraite
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public abstract void SeDeplacer(); //méthode abstraite

    }
}
