using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_KhachHang
    {
        string maKH, tenKH, sDT;

        public ET_KhachHang()
        {
        }

        public ET_KhachHang(string maKH, string tenKH, string sDT)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.SDT = sDT;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
