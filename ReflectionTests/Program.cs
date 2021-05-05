using System;

namespace ReflectionTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            ReflectionUtil.FromClass("DummyClass");

            Console.WriteLine("******************************************");
        }
    }
}
