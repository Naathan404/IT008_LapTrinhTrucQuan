using System;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int ngay, thang, nam;
            // nhap ngay thang nam tu ban phim
            while(true)
            {
                string d, m, y;
                Console.Write("Nhap ngay (1 -> 31): ");
                d = Console.ReadLine();
                Console.Write("Nhap thang (1 -> 12): ");
                m = Console.ReadLine();
                Console.Write("Nhap nam (> 0): ");
                y = Console.ReadLine();

                if ((int.TryParse(d, out ngay) && ngay > 0) && 
                    (int.TryParse(m, out thang) && thang > 0) &&
                    (int.TryParse(y, out nam) && nam > 0))
                    break;

                Console.WriteLine("Dinh dang khong hop le! Vui long nhap so:");
            }
            

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