using System;

namespace DataType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("sbyte:{0} to {1} ", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("byte:{0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("short:{0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("ushort:{0} to {1}", ushort.MinValue,
            ushort.MaxValue);
            Console.WriteLine("int:{0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("long:{0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("decimal:{0} to {1}", decimal.MinValue,
            decimal.MaxValue);
        }
    }
}