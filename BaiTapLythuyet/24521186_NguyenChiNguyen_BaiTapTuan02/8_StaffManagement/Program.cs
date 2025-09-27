using System;

namespace StaffManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<NhanVien> listNV = new List<NhanVien>();

            // nhap
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap loai nhan vien (0: San xuat, 1: Van phong): ");
                int c = Convert.ToInt32(Console.ReadLine());
                if(c == 0)
                {
                    NVSanXuat newNVSX = new NVSanXuat();
                    newNVSX.Nhap();
                    listNV.Add(newNVSX);
                }
                else
                {
                    NVVanPhong newNVVP = new NVVanPhong();
                    newNVVP.Nhap();
                    listNV.Add(newNVVP);
                }
            }

            // xuat 
            for(int i = 0; i < n; i++)
            {
                listNV[i].Xuat();
            }

            // xuat tong luong cong ty can tra
            int tongLuong = 0;
            for(int i = 0; i < n; i++)
            {
                tongLuong += listNV[i].getLuong();
            }
            Console.WriteLine("Tong luong cong ty can tra: " + tongLuong);

            // xuat nhan vien co luon cao nhat
            int max = 0;
            int posKQ = 0;
            for(int i = 0; i < n; i++)
            {
                if (listNV[i].getLuong() > max)
                {
                    max = listNV[i].getLuong();
                    posKQ = i;
                }
            }
            Console.WriteLine("Nhan vien co luong cao nhat: ");
            listNV[posKQ].Xuat();
        }
    }
}
