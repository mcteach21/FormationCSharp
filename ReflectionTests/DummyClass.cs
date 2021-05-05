using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTests
{
    class DummyClass
    {
        public string Name { get; set; }

        public void Hello() => Console.WriteLine("hello from DummyClass!");
        public void Message(string message) => Console.WriteLine($"{message}:{Name}.");

        public static string Info() => "DummyClass!";

        public DummyClass(string name)
        {
            Console.WriteLine($"{this.GetType().Name}..instance create..");
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        public DummyClass(): this("unknown")
        {
        }
    }
}
