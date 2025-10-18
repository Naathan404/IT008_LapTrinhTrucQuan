using System;

namespace LAB2.Bai04
{
    public class PhanSo
    {
        private int _tuSo;
        private int _mauSo;

        public PhanSo(int tuSo = 0, int mauSo = 1)
        {
            _tuSo = tuSo;
            _mauSo = mauSo;
        }

        public int gettuSo() => _tuSo;
        public int getmauSo() => _mauSo;
        public void settuSo(int tuSo) => _tuSo = tuSo;
        public void setmauSo(int mauSo) => _mauSo = mauSo == 0 ? 1 : mauSo;

        public void Nhap()
        {
            while (true)
            {
                Console.Write("Nhap tu so: ");
                string t = Console.ReadLine();
                Console.Write("Nhap mau so: ");
                string m = Console.ReadLine();
                if (!int.TryParse(t, out _tuSo) || !int.TryParse(m, out _mauSo) || _mauSo == 0)
                    Console.WriteLine("Tu hoac mau khong hop le. Vui long nhap lai!");
                else
                    break;
            }
            RutGon();
        }

        public void Xuat()
        {
            if(_tuSo == 0)
            {
                Console.Write("0");
                return;
            }
            else if(_tuSo % _mauSo == 0)
            {
                Console.Write("{0}", _tuSo / _mauSo);
                return;
            }
            Console.Write("{0}/{1}", _tuSo, _mauSo);
        }

        public float GetGiaTri() => (float)_tuSo / _mauSo;

        private int UCLN(int a, int b)
        {
            if (a == 0)
                return b;
            return UCLN(b % a, a);
        }

        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(_tuSo), Math.Abs(_mauSo));
            _tuSo /= ucln;
            _mauSo /= ucln;
            if (_mauSo < 0)
            {
                _tuSo = -_tuSo;
                _mauSo = -_mauSo;
            }
        }

        public static PhanSo operator+(PhanSo a, PhanSo b)
        {
            int tuSo = a._tuSo * b._mauSo + b._tuSo * a._mauSo;
            int mauSo = a._mauSo * b._mauSo;
            PhanSo result = new PhanSo(tuSo, mauSo);
            result.RutGon();
            return result;
        }

        public static PhanSo operator-(PhanSo a, PhanSo b)
        {
            int tuSo = a._tuSo * b._mauSo - b._tuSo * a._mauSo;
            int mauSo = a._mauSo * b._mauSo;
            PhanSo result = new PhanSo(tuSo, mauSo);
            result.RutGon();
            return result;
        }

        public static PhanSo operator*(PhanSo a, PhanSo b)
        {
            int tuSo = a._tuSo * b._tuSo;
            int mauSo = a._mauSo * b._mauSo;
            PhanSo result = new PhanSo(tuSo, mauSo);
            result.RutGon();
            return result;
        }

        public static PhanSo operator/(PhanSo a, PhanSo b)
        {
            int tuSo = a._tuSo * b._mauSo;
            int mauSo = a._mauSo * b._tuSo;
            PhanSo result = new PhanSo(tuSo, mauSo);
            result.RutGon();
            return result;
        }
    }
}
