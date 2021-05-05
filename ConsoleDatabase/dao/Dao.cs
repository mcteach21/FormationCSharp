using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace ConsoleDatabase.dao
{
    class Dao<T> : IDao<T>
    {
        SqlConnection connection = Connections.Instance;
        SqlCommand cmd;
        private string tableName;
        private Type entityType;
        private object entityName;

        public Dao(string tableName) => InitializeEntity(tableName);

        private void InitializeEntity(string tableName)
        {
            this.tableName = tableName;
            //Assembly currentAssembly = Assembly.GetExecutingAssembly();
            this.entityName = Mapping.mappedEntity(this.tableName);
            this.entityType = Type.GetType($"{Assembly.GetExecutingAssembly().GetName().Name}.dao.{entityName}");
        }

        private T readerMapper(SqlDataReader reader)
        {
            return default(T);
             //new User(reader.GetInt32(0), reader.GetString(1));
        }
           
        public List<T> list()
        {
            List<T> items = new List<T>();

            cmd = new SqlCommand($"SELECT * FROM {tableName}", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                 items.Add(readerMapper(reader));
 
            return items;
        }
        public T find(int id)
        {
            throw new NotImplementedException();
        }

        public bool add(T item)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
