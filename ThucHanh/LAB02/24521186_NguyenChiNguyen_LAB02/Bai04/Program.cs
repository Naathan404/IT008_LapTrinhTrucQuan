using System;

namespace LAB2.Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("==========BAI 04 - LAB 2==========");
                Console.WriteLine("1. Chuong trinh hai phan so.");
                Console.WriteLine("2. Chuong trinh danh sach phan so.");
                Console.WriteLine("0. Thoat.");
                Console.Write("Nhap lua chon cua ban: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                    ChuongTrinhHaiPhanSo();
                else if (choice == "2")
                    ChuongTrinhDanhSachPhanSo();
                else
                    return;
            }

        }

        static void ChuongTrinhHaiPhanSo()
        {
            // Nhap vao hai phan so, xuat tong - hieu - tich - thuong cua hai phan so do
            PhanSo _phanSo1 = new PhanSo();
            PhanSo _phanSo2 = new PhanSo();
            // Nhap phan so 1
            Console.WriteLine("Nhap phan so thu 1:");
            _phanSo1.Nhap();
            // Nhap phan so 2
            Console.WriteLine("Nhap phan so thu 2:");
            _phanSo2.Nhap();
            // Xuat hai phan so vua nhap
            Console.Write("Phan so thu nhat la: ");
            _phanSo1.Xuat();
            Console.Write("\nPhan so thu hai la: ");
            _phanSo2.Xuat();

            // Tinh tong
            Console.Write("\nTong hai phan so la: ");
            (_phanSo1 + _phanSo2).Xuat();
            // Tinh hieu
            Console.Write("\nHieu hai phan so la: ");
            (_phanSo1 - _phanSo2).Xuat();
            // Tinh tich
            Console.Write("\nTich hai phan so la: ");
            (_phanSo1 * _phanSo2).Xuat();
            // Tinh thuong
            Console.Write("\nThuong hai phan so la: ");
            (_phanSo1 / _phanSo2).Xuat();

            Console.WriteLine();
        }

        static void ChuongTrinhDanhSachPhanSo()
        {
            DSPhanSo _dsPhanSo = new DSPhanSo();
            // Nhap danh sach phan so
            _dsPhanSo.Nhap();
            // Xuat danh sach phan so
            Console.WriteLine("Danh sach phan so vua nhap:");
            _dsPhanSo.Xuat();

            // Tim phan so lon nhat
            Console.Write("Phan so lon nhat trong danh sach la: ");
            PhanSo maxPhanSo = _dsPhanSo.TimPhanSoLonNhat();
            if (maxPhanSo != null)
                maxPhanSo.Xuat();
            else
                Console.WriteLine("Danh sach rong.");
            Console.WriteLine();

            // Sap xep danh sach tang dan
            _dsPhanSo.SapXepTangDan();
            Console.WriteLine("Danh sach phan so sau khi sap xep tang dan:");
            _dsPhanSo.Xuat();
        }
    }
}