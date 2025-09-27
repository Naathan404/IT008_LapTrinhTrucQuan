using System;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            // Xu li nhap thang/nam
            Console.Write("Nhap thang: ");
            thang = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = Convert.ToInt16(Console.ReadLine());
            while(thang < 1 || thang > 12 || nam < 0)
            {
                Console.WriteLine("Du lieu khong hop le! Vui long nhap lai!");
                Console.Write("Nhap thang: ");
                thang = Convert.ToInt16(Console.ReadLine());
                Console.Write("Nhap nam: ");
                nam = Convert.ToInt16(Console.ReadLine());
            }

            // Tao mang chua ngay cua tung thang trong nam
            int[] ngayTrongThangs = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // Kiem tra nam nhuan
            bool isLeapYear = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);

            // Xuat ket qua
            Console.Write($"So ngay cua thang {thang} nam {nam} la: ");
            if(isLeapYear && thang == 2)
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
