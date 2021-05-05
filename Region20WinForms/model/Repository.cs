using System;
using System.Collections.Generic;
using System.Text;

namespace Region20WinForms.model
{
    class Repository
    {
        static List<User> users = new List<User>() { 
            new User("James","Bond","Hollywood Blvd, 59851 Los Angeles",true, new List<string>(){"Web","CSharp" }),
            new User("Mata","Hari","Cours Lafayette, 69001 Lyon",false, new List<string>(){"Android","Java" })
        };

        public static void Add(User u) => users.Add(u);
        public static List<User> list() => users;
    }
}
