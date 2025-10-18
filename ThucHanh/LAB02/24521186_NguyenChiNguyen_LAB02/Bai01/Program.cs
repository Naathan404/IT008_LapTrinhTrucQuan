using System;

namespace LAB2.Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap du lieu
            int month, year;
            while(true)
            {
                Console.Write("Nhap thang (1->12): ");
                string m = Console.ReadLine();
                Console.Write("Nhap nam (> 0): ");
                string y = Console.ReadLine();
                if((!int.TryParse(m, out month) || !int.TryParse(y, out year))
                    || (month < 1 || month > 12 || year < 1))
                {
                    Console.WriteLine("Invalid data. Please try again!");
                }
                else
                {
                    break;
                }
            }

            // Khai bao cac bien su dung
            DateTime d = new DateTime(year, month, 1);
            int startDay = (int)d.DayOfWeek;
            int dayInMonth = DateTime.DaysInMonth(year, month);

            // Xu ly va in lich ra man hinh
            Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");
            for (int i = 0; i < startDay; i++)
                Console.Write("\t");
            for(int day = 1; day <= dayInMonth; day++)
            {
                Console.Write(day + "\t");
                if((day + startDay)% 7 == 0)
                {
                    Console.Write("\n");
                }
            }
            
        }
    }
}