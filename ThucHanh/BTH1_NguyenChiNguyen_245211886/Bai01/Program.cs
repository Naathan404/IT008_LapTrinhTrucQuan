using System;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tao mang n so nguyen ngau nhien tu 1 den 100
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = CreateRandomArray(n, 1, 100);

            // In mang ra man hinh
            PrintArray(arr, n);

            // a. tinh tong cac so le trong mang
            Console.WriteLine("\nTong cac so le: " + CalculateOddSum(arr, n));

            // b. dem cac so nguyen to trong mang
            Console.WriteLine("So luong so nguyen to: " + CountPrime(arr, n));

            // c. tim so chinh phuong nho nhat
            Console.WriteLine("So chinh phuong nho nhat la: " + FindMinPerfectSquare(arr, n));

            // Tao mang ngau nhien co n phan tu gioi han tu minVal -> maxVal
            static int[] CreateRandomArray(int n, int minVal, int maxVal)
            {
                int[] arr = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(minVal, maxVal);
                }
                return arr;
            }

            // In mang
            static void PrintArray(int[] arr, int n)
            {
                foreach (int a in arr)
                    Console.Write(a + " ");
            }

            // Tinh tong cac so le
            static int CalculateOddSum(int[] arr, int n)
            {
                int sum = 0;
                foreach (int a in arr)
                {
                    if (a % 2 != 0)
                    {
                        sum += a;
                    }
                }
                return sum;
            }

            // Dem so luong so nguyen to
            static int CountPrime(int[] arr, int n)
            {
                int count = 0;
                foreach (int a in arr)
                {
                    if (IsPrime(a))
                    {
                        count++;
                    }
                }
                return count;
            }

            // Tim so chinh phuong nho nhat
            static int FindMinPerfectSquare(int[] arr, int n)
            {
                int ans = int.MaxValue;
                foreach (int a in arr)
                {
                    if (IsPerfectSquare(a) && a < ans)
                    {
                        ans = a;
                    }
                }
                if (ans == int.MaxValue)
                    ans = -1;
                return ans;
            }

            // Kiem tra so chinh phuon
            static bool IsPerfectSquare(int a)
            {
                int i = (int)Math.Sqrt(a);
                if (i * i == a) return true;
                return false;
            }

            // Kiem tra so nguyen to
            static bool IsPrime(int a)
            {
                if (a < 2) return false;
                for (int i = 2; i * i <= a; i++)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }
        }
    }
}