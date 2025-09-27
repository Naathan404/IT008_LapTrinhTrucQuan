using System;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int ngay, thang, nam;
            // nhap ngay thang nam tu ban phim
            Console.Write("Nhap ngay: ");
            ngay = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap thang: ");
            thang = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = Convert.ToInt16(Console.ReadLine());

            // Xuat ket qua ngay/thang/nam co hop le hay khong
            if (IsValidDate(ngay, thang, nam))
                Console.WriteLine("Ngay thang nam hop le!");
            else
                Console.WriteLine("Ngay thang nam khong hop le!");
        }

        // Kiem tra ngay/thang/nam co hop le hay khong
        static bool IsValidDate(int ngay, int thang, int nam)
        {
            if (nam < 0) return false;
            if (thang < 1 || thang > 12) return false;
            if (ngay < 1) return false;
            int[] ngayTrongThangs = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            bool isLeapYear = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
            if (isLeapYear && thang == 2)
            {
                if (ngay > 29) return false;
            }
            else
            {
                if (ngay > ngayTrongThangs[thang - 1]) return false;
            }
            return true;
        }
    }
}