using System;

namespace BTH1.Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            // Nhap n
            while (true)
            {
                Console.Write("Nhap so nguyen duong n (n > 0): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n) && n > 0)
                    break;

                Console.WriteLine("Loi: Vui long nhap mot so nguyen duong hop le!");
            }

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