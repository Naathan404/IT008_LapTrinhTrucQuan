using System;

namespace LAB2.Bai05
{
    public class QuanLyKhuDat
    {
        private List<KhuDat> _danhSachKhuDat;

        public QuanLyKhuDat()
        {
            _danhSachKhuDat = new List<KhuDat>();
        }

        public void ThemKhuDat()
        {
            int choice;
            KhuDat khuDat = new KhuDat();
            while (true)
            {
                Console.WriteLine("Chon loai khu dat can quan ly (1. Khu Dat, 2. Nha Pho, 3. Chung Cu): ");
                Console.Write("Lua chon cua ban (1-3): ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
                    break;
                else
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
            }

            switch (choice)
            {
                case 2:
                    khuDat = new NhaPho();
                    break;
                case 3:
                    khuDat = new ChungCu();
                    break;
            }
            khuDat!.Nhap();
            _danhSachKhuDat.Add(khuDat);
        }

        public void Nhap()
        {
            int soLuong;
            while (true)
            {
                Console.Write("Nhap so luong khu dat can quan ly (> 0): ");
                if (int.TryParse(Console.ReadLine(), out soLuong) && soLuong > 0)
                    break;
                else
                    Console.WriteLine("So luong khong hop le. Vui long nhap lai.");
            }
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"Nhap thong tin cho khu dat thu {i + 1}:");
                ThemKhuDat();
            }
        }

        public void Xuat()
        {
            int i = 1;
            foreach(KhuDat thiTruong in _danhSachKhuDat)
            {
                Console.Write(i++ + ". ");
                thiTruong.Xuat();
                Console.WriteLine();
            }
        }

        public long TinhTongGiaBanKhuDat()
        {
            long tongGiaBan = 0;
            foreach (var thiTruong in _danhSachKhuDat)
            {
                if(thiTruong.GetLoai() == "KHU_DAT")
                    tongGiaBan += thiTruong.GiaBan;
            }
            return tongGiaBan;
        }

        public long TinhTongGiaBanNhaPho()
        {
            long tongGiaBan = 0;
            foreach (var thiTruong in _danhSachKhuDat)
            {
                if (thiTruong is NhaPho)
                    tongGiaBan += thiTruong.GiaBan;
            }
            return tongGiaBan;
        }

        public long TinhTongGiaBanChungCu()
        {
            long tongGiaBan = 0;
            foreach (var thiTruong in _danhSachKhuDat)
            {
                if (thiTruong is ChungCu)
                    tongGiaBan += thiTruong.GiaBan;
            }
            return tongGiaBan;
        }

        public void TimKiemNhaPhoHoacChungCuTheoThongTinCungCap(string diaDiem,long gia, float dienTich)
        {
            bool found = false;
            int i = 1;
            foreach(KhuDat khuDat in _danhSachKhuDat)
            {
                if (khuDat is ChungCu || khuDat is NhaPho)
                {
                    if(khuDat.DiaDiem.ToLower().Contains(diaDiem.ToLower())
                        && khuDat.GiaBan <= gia && khuDat.DienTich >= dienTich)
                    {
                        Console.Write(i++ + ". ");
                        khuDat.Xuat();
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

        public void TimKiemKhuDatHoacNhaPhoTheoDieuKienDacBiet()
        {
            // Dieu kien dac biet:
            // // khu dat co dien tich > 100 m2 hoac
            // // nha pho co dien tich > 60 m2 va nam xay dung >= 2019
            bool found = false;
            int i = 1;
            foreach(KhuDat khuDat in _danhSachKhuDat)
            {
                if(khuDat.GetLoai() == "KHU_DAT" && khuDat.DienTich > 100)
                {
                    Console.Write(i++ + ". ");
                    khuDat.Xuat();
                    found = true;
                    Console.WriteLine();
                }
                else if(khuDat is NhaPho nhaPho 
                    && nhaPho.DienTich > 60 
                    && nhaPho.NamXayDung >= 2019)
                {
                    Console.Write(i++ + ". ");
                    khuDat.Xuat();
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