using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleDatabase.dao
{
    class UserDao : IDao<User>
    {
        SqlConnection connection = Connections.Instance;
        SqlCommand cmd;

        public bool add(User item)
        {
            cmd = new SqlCommand($"INSERT INTO users(name) VALUES('{item.Name}')", connection);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool delete(int id)
        {
            //cmd = new SqlCommand("DELETE FROM users WHERE Id=@id", connection);
            //SqlParameter code = new SqlParameter("@id", id);
            //code.Direction = ParameterDirection.Input;
            //cmd.Parameters.Add(code);

            cmd = new SqlCommand($"DELETE FROM users WHERE Id={id}", connection);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool update(User item)
        {
            cmd = new SqlCommand($"UPDATE users SET Name={item.Name} WHERE Id={item.Id}", connection);
            return cmd.ExecuteNonQuery() > 0;
        }

        public User find(int id)
        {
            cmd = new SqlCommand($"SELECT * FROM users WHERE WHERE Id={id}", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            User item=null;
            if(reader.Read())
                 item = readerMapper(reader);

            return item;
        }

        public List<User> list()
        {
            List<User> items = new List<User>();

            cmd = new SqlCommand("SELECT * FROM users", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            User item;
            while (reader.Read())
            {
                item = readerMapper(reader);
                items.Add(item);
            }

            return items;
        }

        private User readerMapper(SqlDataReader reader) => new User(reader.GetInt32(0), reader.GetString(1));
    }

    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override string ToString()
        {
            return $"[{Id}] {Name}";
        }
    }
}
