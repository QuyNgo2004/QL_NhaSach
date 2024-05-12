using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_HoaDon
    {
        private int maHD;
        private ET_NhanVien maNV;
        private ET_KhachHang maKH;
        private DateTime ngayHD;
        private float tongHD;

        public ET_HoaDon()
        {
            maNV = new ET_NhanVien();
            maKH = new ET_KhachHang();
            ngayHD = DateTime.Now.Date;
        }

        public ET_HoaDon(int maHD, ET_NhanVien maNV, ET_KhachHang maKH, float tongHD)
        {
            this.MaHD = maHD;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.TongHD = tongHD;
        }

        public int MaHD { get => maHD; set => maHD = value; }
        public ET_NhanVien MaNV { get => maNV; set => maNV = value; }
        public ET_KhachHang MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
        public float TongHD { get => tongHD; set => tongHD = value; }
    }
}
