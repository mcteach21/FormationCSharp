using ConsoleDatabase.dao;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("*********** C# : Bases de Données ***********");

            //DataBaseTests();
            DaoTests();
            Console.WriteLine("*********************************************");
        }

        private static void DataBaseTests()
        {
            //1-Connection 
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Tests; Integrated Security=true";
            //string connection_string = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            SqlConnection connection = new SqlConnection(connection_string);
            // ou connection.ConnectionString = connection_string;

            connection.Open();

            //2- Executer Commande (Requete) sur BD
            string command_text = "SELECT * FROM users";

            SqlCommand cmd = new SqlCommand(command_text, connection);
            //cmd.Connection = connection;
            //cmd.CommandText = command_text;

            //SqlCommand cmd = connection.CreateCommand();
            //cmd.CommandText = command_text;

            //Lire données
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("******************************");
            while (reader.Read())
                Console.WriteLine($"{reader.GetInt32(0)}\t{reader["Name"]}");
            Console.WriteLine("******************************");
            reader.Close();

            //Ajouter/Supprimer/Modifier données

            cmd.CommandText = $"INSERT INTO users(name) VALUES('John Doe_{DateTime.Now.ToString("hhmmss")}')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM users WHERE Id=@id";
            SqlParameter code = new SqlParameter("@id", 10);
            code.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(code);

            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE users SET Name='Jane Doe' WHERE Id=1";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM users ORDER BY name";
            reader = cmd.ExecuteReader();
            Console.WriteLine("******************************");
            while (reader.Read())
                Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader["Name"]);
            Console.WriteLine("******************************");

            reader.Close();

            cmd.CommandText = "SELECT * FROM users WHERE Id=@_id";
            cmd.Parameters.Add(new SqlParameter("@_id", 3));
            reader = cmd.ExecuteReader();
            Console.WriteLine("******************************");
            if (reader.Read())
                Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader["Name"]);
            Console.WriteLine("******************************");

            connection.Close();
        }


        private static void DaoTests()
        {
            //var dao = new UserDao();
            ////dao.add(new User(0, "James Bond"));
            ////dao.add(new User(0, "Jason Bourne"));


            


            var dao = new Dao<User>("users");

            var items = dao.list();
            items.ForEach(i => Console.WriteLine(i));

        }
    }
}
