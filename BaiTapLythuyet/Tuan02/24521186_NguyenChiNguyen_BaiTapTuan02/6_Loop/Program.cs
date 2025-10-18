using System;

namespace Loop
{
    public class LoopStatement
    {
        public static void Main(string[] args)
        {
            // for statement
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);

            // while statement
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }

            // do-while statement
            string s;
            do
            {
                s = Console.ReadLine();
                if (s != null) Console.WriteLine(s);
            } while (s != null);

            // foreach statement
            foreach (string s1 in args) Console.WriteLine(s);
        }
    }
}