using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Region20Database.dao
{
    class UserDao : IDao<User>
    {
        SqlConnection connection = Connections.Instance;
        SqlCommand cmd;

        public bool add(User item)
        {
            cmd = new SqlCommand($"INSERT INTO Users(Prenom,Nom) VALUES('{item.Prenom}','{item.Nom}')", connection);
            //requete parametrée..
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool delete(int id)
        {
            //cmd = new SqlCommand("DELETE FROM users WHERE Id=@id", connection);
            //SqlParameter code = new SqlParameter("@id", id);
            //code.Direction = ParameterDirection.Input;
            //cmd.Parameters.Add(code);
            cmd = new SqlCommand($"DELETE FROM Users WHERE Id={id}", connection);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool update(User item)
        {
            cmd = new SqlCommand($"UPDATE Users SET Prenom='{item.Prenom}', Nom='{item.Nom}'  WHERE Id={item.Id}", connection);
            return cmd.ExecuteNonQuery() > 0;
        }

        public User find(int id)
        {
            cmd = new SqlCommand($"SELECT * FROM Users WHERE WHERE Id={id}", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            User item = null;
            if (reader.Read())
                item = readerMapper(reader);

            return item;
        }

        public List<User> list()
        {
            List<User> items = new List<User>();

            cmd = new SqlCommand("SELECT * FROM Users", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            User item;
            while (reader.Read())
            {
                item = readerMapper(reader);
                items.Add(item);
            }

            return items;
        }


        //Transformer enregistrement (table) en objet (User)
        private User readerMapper(SqlDataReader reader)
        {
            return new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
        }
    }

    internal class User
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }

        public User(int id, string prenom, string nom)
        {
            Id = id;
            Nom = nom; // ?? throw new ArgumentNullException(nameof(name));
            Prenom = prenom;
        }

        public override string ToString()
        {
            return $"[{Id}] {Prenom} {Nom}.";
        }
    }
}
