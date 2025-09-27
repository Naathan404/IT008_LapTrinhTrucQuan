using Microsoft.VisualBasic;
using System;

namespace ConsoleWriteline
{
    public class WriteLine
    {
        public static void Main(string[] args)
        {
            int a = 1509, b = 744, c = a + b;

            /// Console.Write functions
            Console.Write("The sum of ");
            Console.Write(a);
            Console.Write(" and ");
            Console.Write(b);
            Console.Write(" equals ");
            Console.Write(c); ;

            // Console.WriteLine
            Console.WriteLine("\n{0} + {1} = {2} ", a, b, c);

            // Standard Numeric Format Specifiers
            Console.WriteLine(
                "(C) Currency:  .   .   .   .   . {0:C}\n" +
                "(D) Decimal:   .   .   .   .   . {0:D}\n" +
                "(E) Scientific:    .   .   .   . {1:E}\n" +
                "(F) Fixed point:   .   .   .   . {1:F}\n" +
                "(G) General:   .   .   .   .   . {0:G}\n" +
                "(default):     .   .   .   .   . {0}\n"   +
                "(N) Number:    .   .   .   .   . {0:N}\n" +
                "(P) Percent:   .   .   .   .   . {1:P}\n" +
                "(R) Round-trip:    .   .   .   . {1:R}\n" +
                "(X) Hexadecimal:   .   .   .   . {0:X}\n",
                -123, -123.45f);

            // Standard DateTime Format Specifiers
            DateTime thisDate = DateTime.Now;
            Console.WriteLine(
                "(d) Short date: . . . . . . .  {0:d}\n" +
                "(D) Long date:. . . . . . . .  {0:D}\n" +
                "(t) Short time: . . . . . . .  {0:t}\n" +
                "(T) Long time:. . . . . . . .  {0:T}\n" +
                "(f) Full date/short time: . .  {0:f}\n" +
                "(F) Full date/long time:. . .  {0:F}\n" +
                "(g) General date/short time:.  {0:g}\n" +
                "(G) General date/long time: .  {0:G}\n" +
                "    (default):. . . . . . . .  {0} (default = 'G')\n" + 
                "(M) Month:. . . . . . . . . .  {0:M}\n" +
                "(R) RFC1123:. . . . . . . . .  {0:R}\n" +
                "(s) Sortable: . . . . . . . .  {0:s}\n" +
                "(u) Universal sortable: . . .  {0:u} (invariant)\n" +
                "(U) Universal sortable: . . .  {0:U}\n" +
                "(Y) Year: . . . . . . . . . .  {0:Y}\n", thisDate);
        }
    }
}
