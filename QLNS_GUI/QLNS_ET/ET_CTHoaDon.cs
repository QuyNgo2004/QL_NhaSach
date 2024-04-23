using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_CTHoaDon
    {
        ET_HoaDon maHD;
        ET_SanPham maSP;
        int sLuong;
        float tTien;

        public ET_CTHoaDon()
        {
            maHD = new ET_HoaDon();
            maSP = new ET_SanPham();
        }

        public ET_CTHoaDon(ET_HoaDon maHD, ET_SanPham maSP, int sLuong)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SLuong = sLuong;
            this.TTien = maSP.GiaSP * sLuong;
        }

        public int SLuong { get => sLuong; set => sLuong = value; }
        public float TTien { get => tTien; set => tTien = value; }
        internal ET_HoaDon MaHD { get => maHD; set => maHD = value; }
        internal ET_SanPham MaSP { get => maSP; set => maSP = value; }
    }
}
