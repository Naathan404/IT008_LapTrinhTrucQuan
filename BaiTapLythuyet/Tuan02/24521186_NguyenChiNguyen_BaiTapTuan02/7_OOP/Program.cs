using System;

namespace Time
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime currTime = DateTime.Now;
            ThoiGian t = new ThoiGian(currTime);
            t.ThoiGianHienHanh();
        }
    }
}
