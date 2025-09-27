using System;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            // Nhap n
            do
            {
                Console.Write("Nhap so nguyen duong n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            // Tinh tong cac so nguyen to nho hon n
            int tongSNT = 0;
            for (int i = 2; i < n; i++)
            {
                if(IsPrime(i))
                {
                    tongSNT += i;
                }
            }
            Console.WriteLine("Tong cac so nguyen to < n: " + tongSNT);
        }

        // Ham kiem tra so nguyen to
        static bool IsPrime(int a)
        {
            if (a < 2) return false;
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
    }
}