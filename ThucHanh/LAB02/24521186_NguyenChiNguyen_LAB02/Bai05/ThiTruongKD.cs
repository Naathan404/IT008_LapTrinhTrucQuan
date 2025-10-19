using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Bai05
{
    public abstract class ThiTruongKD
    {
        protected string _diaDiem;
        protected long _giaBan;
        protected float _dienTich;
        protected Loai _loai;

        // Getters/Setters
        public string DiaDiem
        {
            get { return _diaDiem; }
            set { _diaDiem = value; }
        }
        public long GiaBan
        {
            get { return _giaBan; }
            set { _giaBan = value; }
        }
        public float DienTich
        {
            get { return _dienTich; }
            set { _dienTich = value; }
        }

        public virtual void Nhap()
        {
            // Nhap dia diem
            Console.Write("Nhap dia diem: ");
            _diaDiem = Console.ReadLine();
            // Nhap gia ban
            while (true)
            {
                Console.Write("Nhap gia ban (> 0, VND): ");
                long giaBanInput;
                if (long.TryParse(Console.ReadLine(), out giaBanInput) && giaBanInput > 0)
                {
                    _giaBan = giaBanInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Gia ban khong hop le. Vui long nhap lai.");
                }
            }
            // Nhap dien tich
            while (true)
            {
                Console.Write("Nhap dien tich (> 0, m2): ");
                float dienTichInput;
                if (float.TryParse(Console.ReadLine(), out dienTichInput) && dienTichInput > 0)
                {
                    _dienTich = dienTichInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Dien tich khong hop le. Vui long nhap lai.");
                }
            }
        }

        public virtual void Xuat()
        {
            Console.Write("Loai: " + _loai +
                " | Dia diem: " + _diaDiem + 
                " | Gia ban: " + _giaBan + " VND" + 
                " | Dien tich: " + _dienTich + " m2");
        }
    }

    public class KhuDat : ThiTruongKD
    {
        public KhuDat()
        {
            _loai = Loai.KHU_DAT;
        }
    }

    public class NhaPho : ThiTruongKD
    {
        private int _namXayDung;
        private int _soTang;

        public NhaPho()
        {
            _loai = Loai.NHA_PHO;
        }

        // Getters/Setters
        public int NamXayDung
        {
            get { return _namXayDung; }
            set { _namXayDung = value; }
        }

        public int SoTang
        {
            get { return _soTang; }
            set { _soTang = value; }
        }

        public override void Nhap()
        {
            base.Nhap();
            // Nhap nam xay dung
            while (true)
            {
                Console.Write("Nhap nam xay dung (> 0): ");
                int namXayDungInput;
                if (int.TryParse(Console.ReadLine(), out namXayDungInput) && namXayDungInput > 0)
                {
                    _namXayDung = namXayDungInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Nam xay dung khong hop le. Vui long nhap lai.");
                }
            }
            // Nhap so tang
            while (true)
            {
                Console.Write("Nhap so tang (> 0): ");
                int soTangInput;
                if (int.TryParse(Console.ReadLine(), out soTangInput) && soTangInput > 0)
                {
                    _soTang = soTangInput;
                    break;
                }
                else
                {
                    Console.WriteLine("So tang khong hop le. Vui long nhap lai.");
                }
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" | Nam xay dung: " + _namXayDung + 
                " | So tang: " + _soTang);
        }
    }

    public class ChungCu : ThiTruongKD
    {
        private int _tang;

        public ChungCu()
        {
            _loai = Loai.CHUNG_CU;
        }

        public int GetTang() => _tang;
        public int SetTang(int tang = 1) => _tang = tang;

        public override void Nhap()
        {
            base.Nhap();
            // Nhap tang
            while (true)
            {
                Console.Write("Nhap tang (> 0): ");
                int tangInput;
                if (int.TryParse(Console.ReadLine(), out tangInput) && tangInput > 0)
                {
                    _tang = tangInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Tang khong hop le. Vui long nhap lai.");
                }
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" | Tang: " + _tang);
        }
    }

    public enum Loai
    {
        KHU_DAT,
        NHA_PHO,
        CHUNG_CU
    }
}
