
using Region20Console.classes;
using System;
using System.Collections.Generic;

namespace Region20Console
{
    // CTRL+K+C : commenter bloc
    // CTRL+K+U : decommenter bloc
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Welcome("Region 2020 : Formation C#.");
            //boucles();
            //types_tests();

            //float x = 1500.25198547F;
            //Console.WriteLine(String.Format("{0:#,###.##}", x));

            //Exercices
            //Exercices exos = new Exercices();
            //exos.Lancer();

            TestClasses();
        }
        private static void TestClasses()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("C# : Programmation Objet.");
            Console.WriteLine("*************************************");

            Personne p1 = new Personne("Bond", "James", new DateTime(1950, 8, 26));
            Personne p2 = new Personne("Hari", "Mata", new DateTime(1960, 6, 10));

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine();

            p1.Afficher();
            p2.Afficher("en");

            Console.WriteLine("*************************************");

            Etudiant e1 = new Etudiant("Simpson", "Lisa", new DateTime(1980, 1, 1), "Web", new DateTime(2020, 9, 1));
            Etudiant e2 = new Etudiant("Simpson", "Bart", new DateTime(1990, 1, 1), "Web", new DateTime(2019, 9, 1));

            Formateur f1 = new Formateur("Simpson", "Homer", new DateTime(1970, 1, 1), "Java/JEE", new DateTime(1999, 9, 1));

            e1.Afficher();
            e2.Afficher();

            Console.WriteLine();
            f1.Afficher();
            Console.WriteLine("*************************************");

            List<Personne> people = new List<Personne> {p1, p2, e1, e2, f1};
            foreach (var item in people)
                //Console.WriteLine(item.GetType().Name);
                //item.Afficher();
                if (item.GetType().Name.Equals("Etudiant"))
                {
                    ((Etudiant)item).Afficher();
                    Console.WriteLine();
                }
                else if (item.GetType().Name.Equals("Formateur"))
                {
                    ((Formateur)item).Afficher();
                    Console.WriteLine();
                }
                else
                {
                    item.Afficher();
                    Console.WriteLine();
                }

            Console.WriteLine("*************************************");

            List<Animal> animaux = new List<Animal> {
                new Tortue("Robert", 10),
                new Lievre("Bunny", 15)
            };

            foreach (var item in animaux)
                item.SeDeplacer(); 
                //la 'bonne' méthode sera appelée automatiquement selon le type REEL de item (Tortue ou Lievre)

            Console.WriteLine("*************************************");
        }

        private static void Welcome(String message)
        {
            Console.WriteLine("****************************");
            Console.WriteLine(message);
            Console.WriteLine("****************************");

            Console.Write("Saisir votre nom :");
            string nom =  Console.ReadLine();

            Console.Write("Saisir votre prénom :");
            string prenom = Console.ReadLine();


            // Console.WriteLine("Bienvenue "+prenom+" "+nom+"!");

            string prenom_clean = prenom.Substring(0, 1).ToUpper() + prenom.Substring(1).ToLower();

            //interpolation de chaines
            Console.WriteLine($"Bienvenue {prenom_clean} {nom.ToUpper()}! {nom.Length}");

            //saisie age utilisateur + test si majeur
            Console.WriteLine("Saisir votre âge svp");

            //try
            //{
            //    int age = int.Parse(Console.ReadLine());
            //    if (age >= 18)
            //        Console.WriteLine("Vous pouvez suivre notre formation");
            //    else
            //        Console.WriteLine("Revenez l'année prochaine!");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Format âge non valide!");
            //}

            //tryparse
            int age = 0;
            Boolean parse_ok = int.TryParse(Console.ReadLine(), out age);
            if (parse_ok)
            {
                if (age >= 18)
                    Console.WriteLine("Vous pouvez suivre notre formation");
                else
                    Console.WriteLine("Revenez l'année prochaine!");
            }
            else
            {
                Console.WriteLine($"Format âge non valide! {age}");
            }


            Console.WriteLine("Fin programme!");
        }

        private static void boucles()
        {
            //boucler sur saisie age jusqu'à age valide!
            int age = 0;
            string saisie;

            do
            {
                Console.WriteLine("Saisir votre âge svp.");
                saisie = Console.ReadLine();

                int.TryParse(saisie, out age);
            } while (age<=0);

            if(age>=18)
                Console.WriteLine("Bienvenue dans notre formation!");


            Console.WriteLine("*********************************");
            //afficher en boucle des nombres aleatoires
            Random rnd = new Random();
            int alea;
            for (int i = 0; i < 5; i++)
            {
                alea = rnd.Next(0, 20);
                Console.WriteLine(alea);
            }

            Console.WriteLine("*********************************");
            //string[] modules = new string[5];
            //modules[0] = "Java";
            //modules[1] = "Android";
            //...
            string[] modules = new string[] { "Java", "Android", "C#", "PHP", "Javascript"};
            for (int i = 0; i < modules.Length ; i++)
                Console.WriteLine(i+" : "+modules[i]);

            Console.WriteLine("*********************************");
            foreach (var item in modules)
                Console.WriteLine(item);

            Console.WriteLine("*********************************");
            int i2 = 0;
            while (i2 < modules.Length)
            {
                Console.WriteLine(i2 + " : " + modules[i2]);
                i2++;
            }
        }
        private static void types_tests()
        {
            int a=25, b=10;

            var resultat = (double)a / (double)b;
            Console.WriteLine($"Résultat = {resultat} de type : {resultat.GetType().FullName}.");

            Console.WriteLine($"Résultat Calcul 1 = {diviser(10 , 25)}.");
            Console.WriteLine($"Résultat Calcul 2 = {diviser(10.25 , 25.99)}.");
        }
        private static dynamic calcul(dynamic a, dynamic b)
        {
            return a + b;
        }
        private static dynamic diviser(dynamic a, dynamic b)
        {
            return a/b;
        }
        //private int calcul(int a, int b)
        //{
        //    return a + b;
        //}
        //private double calcul(double a, double b)
        //{
        //    return a + b;
        //}


    }
}
