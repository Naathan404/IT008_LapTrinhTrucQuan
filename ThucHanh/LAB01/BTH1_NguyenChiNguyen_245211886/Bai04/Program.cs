using System;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            // Xu li nhap thang/nam
            while (true)
            {
                string m, y;
                Console.Write("Nhap thang (1 -> 12): ");
                m = Console.ReadLine();
                Console.Write("Nhap nam (> 0): ");
                y = Console.ReadLine();

                if ((int.TryParse(m, out thang) && thang > 0 && thang < 13) &&
                    (int.TryParse(y, out nam) && nam > 0))
                    break;

                Console.WriteLine("Du lieu khong hop le! Vui long nhap lai:");
            }

            // Tao mang chua ngay cua tung thang trong nam
            int[] ngayTrongThangs = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // Kiem tra nam nhuan
            bool isLeapYear = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);

            // Xuat ket qua
            Console.Write($"So ngay cua thang {thang} nam {nam} la: ");
            if (isLeapYear && thang == 2)
            {
                Console.Write(29);
            }
            else
            {
                Console.Write(ngayTrongThangs[thang - 1]);
            }
        }
    }
}
