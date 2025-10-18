using System;

namespace Condition
{
    class ConditionStatement
    {
        private static void Main(string[] args)
        {
            // if statement
            if(args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else
            {
                Console.WriteLine("Has arguments");
            }

            // Switch statement
            int n = args.Length;
            switch (n)
            {
                case 0:
                    Console.WriteLine("No arguments");
                    break;
                case 1:
                    Console.WriteLine("One argument");
                    break;
                default:
                    Console.WriteLine("{0} arguments", n);
                    break;
            }
        }
    }
}