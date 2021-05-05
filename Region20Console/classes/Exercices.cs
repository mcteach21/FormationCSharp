using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Region20Console.classes
{
    class Exercices
    {
        /**
        * Classe Exercices Chapitre 'Bases du Langage'
        */
        private int Menu()
        {
            int choix;
            bool ok;
            do
            {
                Console.WriteLine(" ************************************* ");
                Console.WriteLine(" * Choisir Exercice à lancer          *");
                Console.WriteLine(" ************************************* ");
                Console.WriteLine(" * 1. Valeur Absolue.                 *");
                Console.WriteLine(" * 2. Equation Second Degré.          *");
                Console.WriteLine(" * 3. Nombres d'Armstrong             *");
                Console.WriteLine(" * 4. Nombres Parfaits                *");
                Console.WriteLine(" * 5. Nombres Premiers                *");
                Console.WriteLine(" * 6. Palindrome                      *");
                Console.WriteLine(" * 7. Tri à Bulles                    *");
                Console.WriteLine(" * 8. Quitter Exercices               *");
                Console.WriteLine(" ************************************* ");

                Console.Write("votre choix : ");
                ok = int.TryParse(Console.ReadLine(), out choix);
            } while (!ok || choix <= 0 || choix > 8);

            return choix;
        }

        public void Lancer()
        {
            int choix = 0;
            while (choix != 8)
            {
                choix = Menu();
                //Console.WriteLine($"choix : {choix}");
                //appel méthode exercice / choix!
                switch (choix)
                {
                    case 1:
                        Exercice1();
                        break;
                    case 2:
                        Exercice2();
                        break;
                    case 3:
                        Exercice3();
                        break;
                    case 4:
                        Exercice4();
                        break;
                    case 5:
                        Exercice5();
                        break;
                    case 6:
                        Exercice6();
                        break;
                    case 7:
                        Exercice7();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("bye!");
        }


        public void Exercice1()
        {
            Console.WriteLine("Exercices 'Bases du Langage' : Exercice #1");

            //lire nombre
            int nbre = lireNombre("Veuillez saisir un nombre (+/-) : ");

            //tester nombre (signe) + afficher résultat
            //if (nbre>=0)
            //    Console.WriteLine($"La valeur absolue |x| = {nbre}");
            //else
            //    Console.WriteLine($"La valeur absolue |x| = {-nbre}");

            int nbre_va = (nbre >= 0) ? nbre : -nbre;        //Expression ternaire
            Console.WriteLine($"La valeur absolue |x| = {nbre_va}");
        }

        public void Exercice2()
        {
            Console.WriteLine("Exercices 'Bases du Langage' : Exercice #2");

            int a = lireNombre("Veuillez saisir un nombre (A) : ");
            int b = lireNombre("Veuillez saisir un nombre (B) : ");
            int c = lireNombre("Veuillez saisir un nombre (C) : ");

            double delta, x1, x2;
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine("La solution est un réel!");
                    else
                        Console.WriteLine("Aucune solution!");
                else
                    Console.WriteLine($"la solution est : {-c / b}");
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Aucune solution dans réels!");
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    if (delta != 0)
                        Console.WriteLine($"Les 2 solutions sont : {x1} et {x2}.");
                    else
                        Console.WriteLine($"Une solution unique : {x1}.");
                }
            }

        }
        public void Exercice3()
        {
            Console.WriteLine("Exercices 'Bases du Langage' : Exercice #3");

            int nb;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        nb = 100 * i + 10 * j + k;
                        //Console.WriteLine($"test de..{nb}");
                        if (nb == (i * i * i + j * j * j + k * k * k))
                            Console.WriteLine($"{nb} est un  nombre d'armstrong!");
                    }
                }
            }
        }

        public void Exercice4()
        {
            Console.WriteLine("Exercices 'Bases du Langage' : Exercice #4");
            int nb = 2, combien, trouve = 0, somme;

            combien = lireNombre("Combien voulez-vous de nombres parfaits?");
            while (trouve < combien)
            {
                //nb nombre parfait???
                //Console.WriteLine($"test de {nb}..");
                somme = 0;
                for (int i = 1; i < nb; i++) //faire somme des diviseurs de nb
                {
                    if (nb % i == 0)
                        somme += i;
                }
                if (nb == somme)
                {
                    Console.WriteLine($"{nb} est un nombre parfait!");
                    trouve++;
                }
                nb++;
            }
        }

        public void Exercice5()
        {
            Console.WriteLine("Exercices 'Bases du Langage' : Exercice #5");

            int combien, nb, trouve = 0;
            bool premier;

            combien = lireNombre("Combien voulez-vous de nombres premiers?");

            nb = 3;

            //int[] nombres_premiers = new int[combien];
            //int n = 0;

            List<int> nombres_premiers = new List<int>();

            while (trouve < combien)
            {
                //recherche de nb premier!
                premier = true;
                for (int i = 2; i < nb; i++)
                {
                    if (nb % i == 0)
                    {
                        premier = false;
                        break;
                    }
                }
                if (premier)
                {
                    //Console.WriteLine($"{nb} est un nombre premier!");
                    //nombres_premiers[n++] = nb;
                    nombres_premiers.Add(nb);
                    trouve++;
                }
                nb++;
            }

            Console.WriteLine($"les {combien} nombres premiers trouvés sont : ");
            foreach (var x in nombres_premiers)
                Console.WriteLine($" - {x}");
        }

        public void Exercice6()
        {
            Console.WriteLine("Exercices 'Bases du Langage' : Exercice #6");
            //Eluparcettecrapule !

            Console.WriteLine("Veuillez saisir une phrase :");
            string phrase = Console.ReadLine();

            string phrase_comp = compresser2(phrase.ToLower());
            string phrase_inver = inverser(phrase_comp);

            if (phrase_comp.ToLower().Equals(phrase_inver.ToLower()))
                Console.WriteLine("Cette phrase est un palindrome!");
            else
                Console.WriteLine("Cette phrase n'est pas un palindrome!");
        }

        public void Exercice7()
        {
            Console.WriteLine("Exercices 'Bases du Langage' : Exercice #7");

            List<int> entiers = new List<int>();
            //lire tableau de la console!!

            Console.WriteLine("Veuillez saisir votre tableau d'entiers (valeurs séparées par un espace!).");
            string tablo_txt = Console.ReadLine();
            string[] nbres_txt = tablo_txt.Split(" ");
            int nb;
            foreach (var nbre_txt in nbres_txt)
            {
                if (int.TryParse(nbre_txt, out nb))
                    entiers.Add(nb);
            }

            //int[] entiers = {0 , 25, 7 , 14 , 26 , 25 , 53 , 74 , 99 , 24 , 98 , 89 , 35 , 59 , 38 , 56 , 58 , 36 , 91 , 52};

            Console.WriteLine("Tableau initial (non trié) :");
            for (int i = 0; i < entiers.Count; i++)
                Console.Write(entiers[i] + ((i == entiers.Count - 1) ? "." : ", "));
            Console.WriteLine();

            //tri à bulles
            int temp;
            for (int i = 0; i < entiers.Count - 1; i++)
            {
                for (int j = i + 1; j < entiers.Count; j++)
                {
                    if (entiers[i] > entiers[j])
                    {
                        temp = entiers[i];
                        entiers[i] = entiers[j];
                        entiers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Tableau Trié:");
            for (int i = 0; i < entiers.Count; i++)
                Console.Write(entiers[i] + ((i == entiers.Count - 1) ? "." : ", "));
            Console.WriteLine();
        }

        private string inverser(string phrase_comp)
        {
            char[] cars = phrase_comp.ToCharArray();
            Array.Reverse(cars);

            return new string(cars);
        }

        private string compresser(string phrase)
        {
            string strLoc = "";
            char[] special = { ' ', '\'', ',', '.' };

            for (int i = 0; i < phrase.Length; i++)
                //if(phrase[i]!=' ' && phrase[i] != ',' && phrase[i] != '\'' && phrase[i] != '.')
                if (!special.Contains(phrase[i]))
                    strLoc += phrase[i];

            return strLoc;
        }
        private string compresser2(string phrase)
        {
            return phrase.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("'", "").Replace("é", "e").Replace("è", "e").Replace("à", "a");
        }

        private int lireNombre(string message)
        {
            int nbre = 0;
            bool ok;
            Console.WriteLine(message);
            do
            {
                //try
                //{
                //    nbre = int.Parse(Console.ReadLine());
                //    ok = true;
                //}
                //catch (Exception)
                //{
                //    ok = false;
                //    Console.WriteLine("Nombre saisi non valide! Veuillez ressaisir :");
                //}

                ok = int.TryParse(Console.ReadLine(), out nbre);
                if(!ok)
                    Console.WriteLine("Nombre saisi non valide! Veuillez ressaisir :");

            } while (!ok);

            return nbre;
        }
    }
}
