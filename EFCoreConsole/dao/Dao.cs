using EFCoreConsole;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Region20Database.dao
{
    class Dao<T> : IDao<T>
    {
        const string DbContextName= "BlogDbContext";

        string entityName;
        Type contextType;
        DbContext context;
        PropertyInfo dbSetProperty;
        Type entityType;

        public Dao(string entityName) => InitContext(entityName);
                
        private void InitContext(string entityName)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            
            contextType = Type.GetType($"{currentAssembly.GetName().Name}.{DbContextName}");
            context = (DbContext)Activator.CreateInstance(contextType);
            
            dbSetProperty = contextType.GetProperty($"{entityName}s");

            this.entityName = entityName;
            entityType = Type.GetType($"{currentAssembly.GetName().Name}.{entityName}");
        }

        public List<T> list()
        {
            IQueryable<T> result =  (IQueryable<T>)dbSetProperty.GetValue(context);
            return result.ToList();
        }
        public T find(int id)
        {
            var findMethod = contextType.GetMethod("Find", new[] { typeof(Type) ,  typeof(object[]) });
            var item = (T)findMethod.Invoke(context, 
                new object[] {
                    entityType , new object[] { id } 
                });

            return item;
        }
        public bool add(T item) => action("Add", item);
        public bool delete(T item) => action("Remove", item);

        public bool delete(int id)
        {
            var item = find(id);
            if (item != null)
                return delete(item);
            return false;
        }
        public bool update(T item) => action("Update", item);

        private bool action(string action, T item)
        {
            var actionMethod = contextType.GetMethod(action, new[] { typeof(object) });
            actionMethod.Invoke(context, new object[] { item });

            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Blogs] ON");

            context.SaveChanges();
            return true;
        }
    }
}
