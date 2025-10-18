using System;
using System.Collections.Generic;

namespace BaiTap
{
    interface ISoSanh<T>
    {
        public int SoSanhVoi(T obj2); 
    }

    class SinhVien : ISoSanh<float>
    {
        private string name;
        private float dtb;

        public float getDTB() => dtb;

        public SinhVien(string name = "null", float dtb = 0)
        {
            this.name = name;
            this.dtb = dtb;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            dtb = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {name} \t | Diem tb: {dtb}");
        }

        public int SoSanhVoi(float dtb)
        {
            if (this.dtb > dtb)
                return 1;
            if(this.dtb < dtb)
                return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            List<SinhVien> sinhViens = new List<SinhVien>();

            // Nhap n sinh vien
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu " + (i+1));
                SinhVien sv = new SinhVien();
                sv.Nhap();
                sinhViens.Add(sv);
            }

            // Sap xep sinh vien theo diem tang dan
            sinhViens.Sort((sv1, sv2) => sv1.SoSanhVoi(sv2.getDTB()));

            // Xuat danh sach
            Console.WriteLine("Danh sach sinh vien theo diem tang dan");
            for(int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ". ");
                sinhViens[i].Xuat();
            }
        }
    }
}
