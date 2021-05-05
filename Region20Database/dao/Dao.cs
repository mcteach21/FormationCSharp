using System;
using System.Collections.Generic;
using System.Text;

namespace Region20Database.dao
{
    class Dao<T> : IDao<T>
    {
        string entityName;
        public Dao(string entityName) => this.entityName = entityName;
        public bool add(T item)
        {

            return true;
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public T find(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> list()
        {
            throw new NotImplementedException();
        }

        public bool update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
