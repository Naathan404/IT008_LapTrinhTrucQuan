using System;

namespace ExtensionMethod
{
    sealed class Person
    {
        public string Name { get; set; }
        ///
    }

    static class Utility
    {
        static public void ExMethod(this Person person)
        {
            person.Name = "John";
            Console.WriteLine("Name: " + person.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.ExMethod();
        }
    }
}
