using System;

namespace LAB2.Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows, numCols;   // n: number of rows, m: number of column

            // Nhap so dong va so cot
            while(true)
            {
                Console.Write("Nhap so dong cua ma tran (so dong > 0): ");
                string r = Console.ReadLine();
                Console.Write("Nhap so cot cua ma tran (so cot > 0): ");
                string c = Console.ReadLine();  
                if((!int.TryParse(r, out numRows) || !int.TryParse(c, out numCols))
                    || (numRows <= 0 || numCols <= 0))
                    Console.WriteLine("So dong hoac so sot khong hop le. Vui long nhap lai! ");
                else
                    break;
            }

            Matrix matrix = new Matrix(numRows, numCols);

            // a. Nhap/Xuat ma tran
            Console.WriteLine("Nhap ma tran: ");
            matrix.Nhap();
            Console.WriteLine("Ma tran vua nhap: ");
            matrix.Xuat();

            // b. Tim kiem phan tu trong ma tran
            Console.Write("Nhap phan tu can tim  (so nguyen): ");
            int ele;
            while(true)
            {
                string input = Console.ReadLine();
                if(!int.TryParse(input, out ele))
                    Console.WriteLine("Du lieu vua nhap khong hop le. Vui long nhap lai!");
                else
                    break;
            }
            if (matrix.FindElement(ele))
                Console.WriteLine("Phan tu {0} co ton tai trong ma tran.", ele);
            else
                Console.WriteLine("Phan tu {0} khong ton tai trong ma tran.", ele);

            // c. Xuat cac phan tu la so nguyen to trong ma tran
            Console.WriteLine("Cac phan tu la so nguyen to trong ma tran: ");
            if(!matrix.PrintPrime())
            {
                Console.WriteLine("Khong co phan tu nao la so nguyen to trong ma tran.");
            }

            // d. Tim dong co so luong so nguyen to nhieu nhat
            int maxPrimeCount = matrix.MaxPrimeCountRow();
            Console.WriteLine("\nDong co nhieu so nguyen to nhat trong ma tran la: {0}", maxPrimeCount);
        }

        private static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) 
                    return false;
            return true;
        }

        // lop Matrix de thuc hien cac yeu cau cua de bai
        public class Matrix
        {
            int numRows, numCols;
            int[][] matrix;
            public Matrix(int numRows = 0, int numCols = 0)
            {
                this.numRows = numRows;
                this.numCols = numCols;
                matrix = new int[this.numRows][];
                for (int i = 0; i < this.numRows; i++)
                {
                    matrix[i] = new int[numCols];
                }
            }

            // Ham nhap ma tran
            public void Nhap()
            {
                for (int i = 0; i < numRows; i++)
                {
                    string[] parts = Console.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < numCols; j++)
                    {
                        if(j < parts.Length && int.TryParse(parts[j], out matrix[i][j]))
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Invalid data. Please enter the row again:");
                            j--;
                        }
                    }
                }
            }

            // Ham xuat ma tran
            public void Xuat()
            {
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        Console.Write(matrix[i][j] + " ");
                    }
                    Console.Write("\n");
                }
            }

            // Tim kiem 
            public bool FindElement(int ele)
            {
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        if(matrix[i][j] == ele)
                            return true;
                    }
                }
                return false;
            }

            // Xuat cac phan tu la so nguyen to
            public bool PrintPrime()
            {
                bool found = false;
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        if (IsPrime(matrix[i][j]))
                        {
                            Console.Write(matrix[i][j] + " ");
                            found = true;
                        }
                    }
                }
                return found;
            }

            // Tim dong co so luong so nguyen to nhieu nhat
            public int MaxPrimeCountRow()
            {
                int res = -1; // Tra ve -1 neu ma tran khong co so nguyen to
                int primeCount = 0;
                for(int i = 0; i < numRows; i++)
                {
                    int temp = 0;
                    for(int j = 0; j < numCols; j++)
                    {
                        if (IsPrime(matrix[i][j]))
                            temp++;
                    }
                    if(temp > primeCount)
                    {
                        primeCount = temp;
                        res = i;
                    }
                }
                return res;
            }
        }
    }
}