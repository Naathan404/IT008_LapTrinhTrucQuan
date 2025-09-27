using System;

namespace Time
{
    public class ThoiGian
    {
        // Cac bien thanh vien
        int Nam { get; set; }
        int Thang;
        int Ngay;
        int Gio;
        int Phut;
        int Giay;

        public ThoiGian(DateTime d)
        {
            Nam = d.Year;
            Thang = d.Month;
            Ngay = d.Day;
            Gio = d.Hour;
            Phut = d.Minute;
            Giay = d.Second;
        }
        public void ThoiGianHienHanh()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Thoi gian hien tai: \t {0}/{1}/{2} \t {3}:{4}:{5}", 
                now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second);
            Console.WriteLine("Thoi gian: \t {0}/{1}/{2} \t {3}:{4}:{5}", Ngay, Thang, Nam, Gio, Phut, Giay);
        }

        
    }
}