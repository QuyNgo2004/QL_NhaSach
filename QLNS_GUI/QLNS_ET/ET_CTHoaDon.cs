using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_CTHoaDon
    {
        private int maCTHD;
        private ET_HoaDon maHD;
        private ET_SanPham maSP;
        private int sLuong;
        private float tTien;

        public ET_CTHoaDon()
        {
            maHD = new ET_HoaDon();
            maSP = new ET_SanPham();
        }

        public ET_CTHoaDon(int maCTHD,ET_HoaDon maHD, ET_SanPham maSP, int sLuong)
        {
            this.MaCTHD = maCTHD;
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SLuong = sLuong;
            this.TTien = maSP.GiaSP * sLuong;
        }

        public int SLuong { get => sLuong; set => sLuong = value; }
        public float TTien { get => tTien; set => tTien = value; }
        public int MaCTHD { get => maCTHD; set => maCTHD = value; }
        public ET_HoaDon MaHD { get => maHD; set => maHD = value; }
        public ET_SanPham MaSP { get => maSP; set => maSP = value; }
    }
}
