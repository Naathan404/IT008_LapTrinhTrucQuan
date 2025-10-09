using System;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            int ngay, thang, nam;
            // Nhap ngay thang nam tu ban phim
            while(true)
            {
                string d, m, y;
                Console.Write("Enter the day: ");
                d = Console.ReadLine();
                Console.Write("Enter the month: ");
                m = Console.ReadLine();
                Console.Write("Enter the year: ");
                y = Console.ReadLine();

                if(int.TryParse(d, out ngay) && int.TryParse(m, out thang) && int.TryParse(y, out nam) 
                    && IsValidDate(ngay, thang, nam))
                    break;
                Console.WriteLine("Invalid data. Please try again!");
            }
            // Khai bao doi tuong kieu DateTime va truyen doi so ngay/thang/nam de tan dung ham DayOfWeek
            DateTime date = new DateTime(nam, thang, ngay);
            Console.WriteLine("{0}/{1}/{2} is: " + date.DayOfWeek, ngay, thang, nam);
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
