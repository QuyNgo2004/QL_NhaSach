using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_CTKhuyenMai
    {
        private int maCTKM;
        private ET_SanPham maSP;
        private ET_KhuyenMai maKM;
        private DateTime ngayBD, ngayKT;

        public ET_CTKhuyenMai()
        {
            maSP = new ET_SanPham();
            maKM = new ET_KhuyenMai(); 
        }

        public ET_CTKhuyenMai(int maCTKM ,ET_SanPham maSP, ET_KhuyenMai maKM, DateTime ngayBD, DateTime ngayKT)
        {
            this.MaCTKM = maCTKM;
            this.MaSP = maSP;
            this.MaKM = maKM;
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
        }

        public ET_SanPham MaSP { get => maSP; set => maSP = value; }
        public ET_KhuyenMai MaKM { get => maKM; set => maKM = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
        public int MaCTKM { get => maCTKM; set => maCTKM = value; }
    }
}
