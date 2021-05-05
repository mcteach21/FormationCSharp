using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleDatabase.dao
{
    class Connections
    {
        static SqlConnection connection = null;
        static string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Tests; Integrated Security=true";

        public static SqlConnection Instance
        {
            get
            {
                if (connection == null)
                    connection = new SqlConnection(connection_string);

                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                return connection;
            }
        }
        public static void Close()
        {
            if (connection != null)
                connection.Close();
        }
    }
}
