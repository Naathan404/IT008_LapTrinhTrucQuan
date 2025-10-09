using System;

namespace Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows, numCols;   // n: number of rows, m: number of column

            // Nhap so dong va so cot
            while (true)
            {
                string r, c;
                Console.Write("Nhap so dong: ");
                r = Console.ReadLine();
                Console.Write("Nhap so cot: ");
                c = Console.ReadLine();
                if((int.TryParse(r, out numRows) && numRows > 0) && (int.TryParse(c, out numCols) && numCols > 0))
                    break;
                Console.WriteLine("So dong va so cot phai la so nguyen duong. Vui long nhap lai!");
            }


            Matrix matrix = new Matrix(numRows, numCols);

            // a. Xuat ma tran
            Console.WriteLine("Ma tran da duoc khoi tao ngau nhien!");
            Console.WriteLine("a. Xuat ma tran: ");
            matrix.Print();

            // b. Tim max/min
            Console.WriteLine("b. Tim phan tu lon nhat/ nho nhat trong ma tran: ");
            Console.WriteLine("\t-Phan tu lon nhat cua ma tran la: {0}", matrix.FindMax());
            Console.WriteLine("\t-Phan tu nho nhat cua ma tran la: {0}", matrix.FindMin());


            // c. Xuat dong co tong lon nhat
            Console.WriteLine($"c. Dong co tong lon (tinh tu 0) nhat la dong thu {matrix.FindMaxSumRow()}");

            // d. Tinh tong cac so khong phai la so nguyen to
            Console.WriteLine($"d. Tong cac so khong phai la so nguyen to la {matrix.FindNonPrimeSum()}");

            // e. Xoa dong thu k trong ma tran
            Console.WriteLine("e. Xoa dong thu k trong ma tran:");
            // Nhap dong can xoa
            int k;
            do
            {
                Console.Write("Nhap dong can xoa (tinh tu 0): ");
                k = Convert.ToInt16(Console.ReadLine());
            } while (k >= numRows || k < 0);
            // Xoa
            matrix.DeleteRow(k);
            // In ma tran
            Console.WriteLine($"Ma tran sau khi xoa dong thu {k}: ");
            matrix.Print();

            /// f. Xoa cot chua phan tu lon nhat
            Console.WriteLine("f. Xoa cot chua phan tu lon nhat trong ma tran: ");
            // Tim cot chua phan tu lon nhat
            int colToDel = matrix.FindMaxEleColumnIndex();
            // Xoa cot vua tim duoc
            matrix.DeleteColumn(colToDel);
            // In ma tran
            Console.WriteLine($"Ma tran sau khi xoa cot thu {colToDel} (cot chua phan tu lon nhat) la: ");
            matrix.Print();
        }

        private static bool isPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
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
                Random rnd = new Random();
                for (int i = 0; i < this.numRows; i++)
                {
                    matrix[i] = new int[numCols];
                    for (int j = 0; j < numCols; j++)
                    {
                        matrix[i][j] = rnd.Next(1, 20);
                    }
                }
            }

            public void Print()
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

            public int FindMax()
            {
                int maxValue = int.MinValue;
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        if (matrix[i][j] > maxValue)
                            maxValue = matrix[i][j];
                    }
                }
                return maxValue;
            }

            public int FindMin()
            {
                int minValue = int.MaxValue;
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        if (matrix[i][j] < minValue)
                            minValue = matrix[i][j];
                    }
                }
                return minValue;
            }

            public int FindMaxSumRow()
            {
                int maxRowSum = 0;
                int maxRowIdx = 0;
                for (int i = 0; i < numRows; i++)
                {
                    int tempSum = 0;
                    for (int j = 0; j < numCols; j++)
                    {
                        tempSum += matrix[i][j];
                    }
                    if (tempSum > maxRowSum)
                    {
                        maxRowSum = tempSum;
                        maxRowIdx = i;
                    }
                }
                return maxRowIdx;
            }

            public int FindNonPrimeSum()
            {
                int tongKhongPhaiSoNguyenTo = 0;
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        if (!isPrime(matrix[i][j]))
                        {
                            tongKhongPhaiSoNguyenTo += matrix[i][j];
                        }
                    }
                }
                return tongKhongPhaiSoNguyenTo;
            }

            public void DeleteRow(int rowToDelete)
            {
                if (rowToDelete == numRows - 1)
                {
                    numRows--;
                }
                else
                {
                    for(int r = rowToDelete; r < numRows - 1; r++)
                    {
                        for (int i = 0; i < numCols; i++)
                        {
                            matrix[r][i] = matrix[r + 1][i];
                        }
                    }
                    numRows--;
                }
            }

            public int FindMaxEleColumnIndex()
            {
                int maxValue = FindMax();
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        if (matrix[i][j] == maxValue)
                            return j;
                    }
                }
                return -1;
            }
            public void DeleteColumn(int colToDelete)
            {
                if (colToDelete == numCols - 1)
                    numCols--;
                else
                {
                    for (int c = colToDelete; c < numCols - 1; c++)
                    {
                        for(int i = 0; i < numRows; i++)
                        {
                            matrix[i][c] = matrix[i][c + 1];
                        }
                    }
                    numCols--;
                }
                    
            }
        }
    }
} 