using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_KhuyenMai
    {
        ET_SanPham maSP;
        string maKM, tenKM;
        float giamGia;

        public ET_KhuyenMai()
        {
            maSP = new ET_SanPham();
        }

        public ET_KhuyenMai(string maKM, string tenKM, ET_SanPham maSP, float giamGia)
        {
            this.MaKM = maKM;
            this.TenKM = tenKM;
            this.MaSP = maSP;
            this.GiamGia = giamGia;
        }

        public string MaKM { get => maKM; set => maKM = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public ET_SanPham MaSP { get => maSP; set => maSP = value; }
        public float GiamGia { get => giamGia; set => giamGia = value; }
    }
}
