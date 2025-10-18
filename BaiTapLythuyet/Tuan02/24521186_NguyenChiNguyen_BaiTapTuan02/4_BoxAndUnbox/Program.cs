using System;


public class Program
{
    public static void Main(string[] args)
    {
        int i = 123;
        object o = i;
        int j = (int)o;
        Console.WriteLine(i);
        Console.WriteLine(o);
        Console.WriteLine(j);
    }
}
