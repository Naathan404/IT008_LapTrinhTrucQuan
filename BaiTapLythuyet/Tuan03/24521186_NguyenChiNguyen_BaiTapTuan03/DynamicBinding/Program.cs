using System;

class Person
{
    public string Name { get; set; }
    public void Swim()
    {
        Console.WriteLine("Person is swimming");
    }
}

class Duck
{
    public string Weight { get; set; }
    public void Swim()
    {
        Console.WriteLine("The Duck is swimming");
    }
}

class Program
{
    static void InvokeSwim(dynamic obj)
    {
        obj.Swim();
    }

    static void Main(string[] args)
    {
        dynamic person = new Person();
        dynamic duck = new Duck();
        
        // Truyen vao cung 1 ham hai dynamic obj khac nhau
        InvokeSwim(person);
        InvokeSwim(duck);
    }
}