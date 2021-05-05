using Region20Database.dao;
using System;
using System.Data.SqlClient;

namespace Region20Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Gestion Bases de Données!");
            Console.WriteLine("****************************");

            //Connection + Tests sur Base de Données
            //DatabaseTests();

            //Tests Dao!
            UserDao dao = new UserDao();

            dao.add(new User(0, "John", "Doe"));
            dao.add(new User(0, "Jane", "Doe"));

            var items = dao.list();
            Console.WriteLine("****************************");
            foreach (var item in items)
                Console.WriteLine(item);
            Console.WriteLine("****************************");

            //ajouter fermeture connection à partir Dao!
        }
        
        private static void DatabaseTests()
        {
            Console.WriteLine("****************************");
            //1 : Connection à la Base de Données
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Regions2020;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            Console.WriteLine($"Connection à la BD : {connection.Database} OK!");

            //2: Utiliser BD!

            SqlCommand command = new SqlCommand("SELECT * FROM Users ORDER BY Nom", connection);
            var reader = command.ExecuteReader();

            int id;
            string prenom, nom;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                prenom = reader.GetString(1);
                nom = reader.GetString(2);

                Console.WriteLine($"{id} : {prenom} {nom}.");
            }
            reader.Close();


            //requete action : insert
            prenom = "Bart";
            nom = "Simpson";
            //command.CommandText = $"INSERT INTO Users(Prenom, Nom) VALUES('{prenom}','{nom}')";

            command.CommandText = $"INSERT INTO Users(Prenom, Nom) VALUES(@prenom,@nom)";
            command.Parameters.Add(new SqlParameter("@prenom", prenom));
            command.Parameters.Add(new SqlParameter("@nom", nom));

            int result = command.ExecuteNonQuery();
            if(result>0)
                Console.WriteLine($"Item ajouté avec succès! {result}");

            //requete action : suppression!
            command.CommandText = $"DELETE FROM Users WHERE Nom=@nom_delete";
            command.Parameters.Add(new SqlParameter("@nom_delete", nom));
            result = command.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine($"Item(s) supprimé(s) avec succès! {result}");


            Console.WriteLine();
            //select
            command.CommandText = "SELECT * FROM Users ORDER BY Nom";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                prenom = reader.GetString(1);
                nom = reader.GetString(2);
                Console.WriteLine($"{id} : {prenom} {nom}.");
            }
            reader.Close();

            connection.Close();
            Console.WriteLine("****************************");
        }
    }
}
