using System;

namespace LAB2.Bai04
{
    public class DSPhanSo
    {
        private List<PhanSo> _dSPhanSo;

        public DSPhanSo()
        {
            _dSPhanSo = new List<PhanSo>();
        }

        public void Nhap()
        {
            int n;
            while(true)
            {
                Console.Write("Nhap so luong phan so: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out n) || n <= 0)
                    Console.WriteLine("So luong khong hop le. Vui long nhap lai!");
                else
                    break;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan so thu {0}:", i + 1);
                PhanSo ps = new PhanSo();
                ps.Nhap();
                _dSPhanSo.Add(ps);
            }
        }

        public void Xuat()
        {
            foreach (var ps in _dSPhanSo)
            {
                ps.Xuat();
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        public PhanSo TimPhanSoLonNhat()
        {
            if (_dSPhanSo.Count == 0)
                return null;
            PhanSo maxPhanSo = _dSPhanSo[0];
            foreach (var ps in _dSPhanSo)
            {
                if (ps.GetGiaTri() > maxPhanSo.GetGiaTri())
                    maxPhanSo = ps;
            }
            return maxPhanSo;
        }

        public void SapXepTangDan()
        {
            _dSPhanSo.Sort((ps1, ps2) => ps1.GetGiaTri().CompareTo(ps2.GetGiaTri()));
        }
    }
}
