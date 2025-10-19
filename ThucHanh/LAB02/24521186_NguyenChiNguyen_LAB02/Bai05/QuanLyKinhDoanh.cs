using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Bai05
{
    public class QuanLyKinhDoanh
    {
        private List<ThiTruongKD> _danhSachThiTruong;

        public QuanLyKinhDoanh()
        {
            _danhSachThiTruong = new List<ThiTruongKD>();
        }

        public void ThemThiTruong()
        {
            int choice;
            ThiTruongKD thiTruong = null;
            while (true)
            {
                Console.WriteLine("Chon loai thi truong (1. Khu Dat, 2. Nha Pho, 3. Chung Cu): ");
                Console.Write("Lua chon cua ban (1-3): ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
                    break;
                else
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
            }

            switch (choice)
            {
                case 1:
                    thiTruong = new KhuDat();
                    break;
                case 2:
                    thiTruong = new NhaPho();
                    break;
                case 3:
                    thiTruong = new ChungCu();
                    break;
            }
            thiTruong.Nhap();
            _danhSachThiTruong.Add(thiTruong);
        }

        public void Nhap()
        {
            int soLuong;
            while (true)
            {
                Console.Write("Nhap so luong thi truong can them (> 0): ");
                if (int.TryParse(Console.ReadLine(), out soLuong) && soLuong > 0)
                    break;
                else
                    Console.WriteLine("So luong khong hop le. Vui long nhap lai.");
            }
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\nNhap thong tin cho thi truong thu {i + 1}:");
                ThemThiTruong();
            }
        }

        public void Xuat()
        {
            int i = 1;
            foreach(ThiTruongKD thiTruong in _danhSachThiTruong)
            {
                Console.Write(i++ + ". ");
                thiTruong.Xuat();
                Console.WriteLine();
            }
        }

        public long TinhTongGiaBan()
        {
            long tongGiaBan = 0;
            foreach (var thiTruong in _danhSachThiTruong)
            {
                tongGiaBan += thiTruong.GiaBan;
            }
            return tongGiaBan;
        }

        public long TinhTongGiaBanKhuDat()
        {
            long tongGiaBan = 0;
            foreach (var thiTruong in _danhSachThiTruong)
            {
                if(thiTruong is KhuDat)
                    tongGiaBan += thiTruong.GiaBan;
            }
            return tongGiaBan;
        }

        public long TinhTongGiaBanNhaPho()
        {
            long tongGiaBan = 0;
            foreach (var thiTruong in _danhSachThiTruong)
            {
                if (thiTruong is NhaPho)
                    tongGiaBan += thiTruong.GiaBan;
            }
            return tongGiaBan;
        }

        public long TinhTongGiaBanChungCu()
        {
            long tongGiaBan = 0;
            foreach (var thiTruong in _danhSachThiTruong)
            {
                if (thiTruong is ChungCu)
                    tongGiaBan += thiTruong.GiaBan;
            }
            return tongGiaBan;
        }

        public void TimKiemNhaPhoHoacChungCuTheoThongTinCungCap(string diaDiem,long gia, float dienTich)
        {
            bool found = false;
            foreach(ThiTruongKD thiTruong in _danhSachThiTruong)
            {
                if (thiTruong is ChungCu || thiTruong is NhaPho)
                {
                    if(thiTruong.DiaDiem.ToLower().Contains(diaDiem.ToLower())
                        && thiTruong.GiaBan <= gia && thiTruong.DienTich >= dienTich)
                    {
                        thiTruong.Xuat();
                        found = true;
                        Console.WriteLine();
                    }

                }
            }
            if(!found)
            {
                Console.WriteLine("Khong tim thay nha pho hay chung cu thoa man dieu kien tim kiem!");
            }
        }

        public void TimKiemKhuDatHoacNhaPhoTheoDieuKienDatBieṭ()
        {
            // Dieu kien dac biet:
            // // khu dat co dien tich > 100 m2 hoac
            // // nha pho co dien tich > 60 m2 va nam xay dung >= 2019
            bool found = false;
            foreach(ThiTruongKD thiTruong in _danhSachThiTruong)
            {
                if(thiTruong is KhuDat khuDat && khuDat.DienTich > 100)
                {
                    thiTruong.Xuat();
                    found = true;
                    Console.WriteLine();
                }
                else if(thiTruong is NhaPho nhaPho 
                    && nhaPho.DienTich > 60 
                    && nhaPho.NamXayDung >= 2019)
                {
                    thiTruong.Xuat();
                    found = true;
                    Console.WriteLine();
                }
            }
            if(!found)
            {
                Console.WriteLine("Khong tim thay khu dat va nha pho phu hop.");
            }
        }
    }
}