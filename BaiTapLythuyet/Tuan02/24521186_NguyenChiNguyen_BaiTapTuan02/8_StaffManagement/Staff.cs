using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagement
{
    public abstract class NhanVien
    {
        protected string hoTen;
        protected string ngaySinh;
        protected int luong = 0;

        public int getLuong() => luong;
        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            ngaySinh = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ho ten: {0} \t Ngay sinh: {1} \t Luong: {2:C} \n", hoTen, ngaySinh, luong);
        }

        public abstract int TinhLuong();
    }

    public class NVSanXuat : NhanVien
    {
        int luongCB, soSP;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            luongCB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so san pham: ");
            soSP = Convert.ToInt32(Console.ReadLine());
            luong = TinhLuong();
        }
        public override int TinhLuong()
        {
            return luongCB + soSP * 5000;
        }
    }

    public class NVVanPhong : NhanVien
    {
        int soNgay;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ngay lam: ");
            soNgay = Convert.ToInt32(Console.ReadLine());
            luong = TinhLuong();
        }

        public override int TinhLuong()
        {
            return soNgay * 100000;
        }
    }
}
