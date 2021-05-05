using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionTests
{
    class ReflectionUtil
    {

        public static void FromClass(string className)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Console.WriteLine($"Current Assembly : {currentAssembly.GetName().Name}");

            Type type = Type.GetType($"{currentAssembly.GetName().Name}.{className}");
            var instance = Activator.CreateInstance(type);
            Console.WriteLine($"instance of {className} : {instance}.");

            string methodName = "Hello";
            MethodInfo method = type.GetMethod(methodName);

            method.Invoke(instance, null);


            methodName = "Message";
            method = type.GetMethod(methodName, new Type[] { typeof(string) });

            method.Invoke(instance, new string[] {"welcome!"});

            //static
            methodName = "Info";
            method = type.GetMethod(methodName);

            Console.WriteLine(method.Invoke(null, null));

            //props
            var prop = type.GetProperty("Name");
            Console.WriteLine($"property {prop.Name} : value = {prop.GetValue(instance)}.");

        }
    }
}
