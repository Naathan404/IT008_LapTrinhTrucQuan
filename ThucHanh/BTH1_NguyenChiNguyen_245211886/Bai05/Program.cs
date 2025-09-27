using System;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            int ngay, thang, nam;
            // Nhap ngay thang nam tu ban phim
            Console.Write("Enter your day: ");
            ngay = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter your month: ");
            thang = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter your year: ");
            nam = Convert.ToInt16(Console.ReadLine());
            while (!IsValidDate(ngay, thang, nam))
            {
                Console.WriteLine("Invalid data. Please try again!");
                Console.Write("Enter your day: ");
                ngay = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter your month: ");
                thang = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter your year: ");
                nam = Convert.ToInt16(Console.ReadLine());
            }
            // Khai bao doi tuong kieu DateTime va truyen doi so ngay/thang/nam de tan dung ham DayOfWeek
            DateTime d = new DateTime(nam, thang, ngay);
            Console.WriteLine("{0}/{1}/{2} is: " + d.DayOfWeek, ngay, thang, nam);
        }

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
