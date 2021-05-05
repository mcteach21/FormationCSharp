using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDatabase.dao
{
    class Mapping
    {
        static Dictionary<string, string> map = new Dictionary<string, string>()
        {
            {"users", "User"},
            {"todos", "Todo" }
        };

        public static string mappedEntity(string tableName) => map.GetValueOrDefault(tableName);
    }
}
