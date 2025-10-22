using System;

namespace LAB2.Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyKhuDat quanLyKhuDat = new QuanLyKhuDat();

            while (true)
            {
                Console.WriteLine("==========BAI 05 - LAB 2==========");
                Console.WriteLine("1. Nhap danh sach khu dat.");
                Console.WriteLine("2. Xuat danh sach khu dat.");
                Console.WriteLine("3. Tinh tong gia ban khu dat.");
                Console.WriteLine("4. Tinh tong gia ban nha pho.");
                Console.WriteLine("5. Tinh tong gia ban chung cu.");
                Console.WriteLine("6. Tim kiem nha pho hoac chung cu theo dia diem, gia ban va dien tich.");
                Console.WriteLine("7. Tim kiem khu dat co dien tich > 100m2 hoac nha pho co dien tich > 60m2 va nam xay dung >= 2019.");
                Console.WriteLine("0. Thoat.");
                Console.Write("Nhap lua chon cua ban: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        quanLyKhuDat.Nhap();
                        break;
                    case "2":
                        quanLyKhuDat.Xuat();
                        break;
                    case "3":
                        Console.WriteLine($"Tong gia ban khu dat: {quanLyKhuDat.TinhTongGiaBanKhuDat()}");
                        break;
                    case "4":
                        Console.WriteLine($"Tong gia ban nha pho: {quanLyKhuDat.TinhTongGiaBanNhaPho()}");
                        break;
                    case "5":
                        Console.WriteLine($"Tong gia ban chung cu: {quanLyKhuDat.TinhTongGiaBanChungCu()}");
                        break;
                    case "6":
                        Console.Write("Nhap dia diem can tim: ");
                        string diaDiem = Console.ReadLine();
                        long gia;
                        float dienTich;
                        while(true)
                        {
                            Console.Write("Nhap gia can tim: ");
                            if (long.TryParse(Console.ReadLine(), out gia) && gia > 0)
                                break;
                            else
                                Console.WriteLine("Gia khong hop le. Vui long nhap lai!");
                        }
                        while (true)
                        {
                            Console.Write("Nhap dien tich can tim: ");
                            if (float.TryParse(Console.ReadLine(), out dienTich) && dienTich > 0)
                                break;
                            else
                                Console.WriteLine("Dien tich khong hop le. Vui long nhap lai!");
                        }
                        Console.Write("Thong tin nha pho hoac chung cu tim duoc:\n");
                        quanLyKhuDat.TimKiemNhaPhoHoacChungCuTheoThongTinCungCap(diaDiem, gia, dienTich);
                        break;
                    case "7":
                        Console.Write("Thong tin khu dat hoac nha pho tim duoc:\n");
                        quanLyKhuDat.TimKiemKhuDatHoacNhaPhoTheoDieuKienDacBiet();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
