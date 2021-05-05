using System;
using System.Collections.Generic;
using System.Text;

namespace Region20Console.classes
{
    class Lievre : Animal
    {
        public Lievre(string nom, int age) : base(nom, age)
        {
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je suis un lievre et je cours très vite!");
        }
    }
}
