using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class Booking
    {
        public string MaDatPhong { get; set; }
        public string TenKhach { get; set; }
        public string SoDienThoai { get; set; }
        public string LoaiPhong { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }
        public decimal TienCoc { get; set; }
        public decimal TongTien { get; set; }

        public int SoDem()
        {
            return (NgayTra - NgayNhan).Days;
        }
    }
}
