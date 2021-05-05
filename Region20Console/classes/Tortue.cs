using System;
using System.Collections.Generic;
using System.Text;

namespace Region20Console.classes
{
    class Tortue : Animal
    {
        public Tortue(string nom, int age) : base(nom, age)
        {
        }

        public override void SeDeplacer()
        {
            //implementation méthode abstraite (dans Animal)
            Console.WriteLine("Je suis une tortue et je me déplace très lentement!");
        }
    }
}
