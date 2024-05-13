using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_TaiKhoan
    {
        private ET_NhanVien maNV;
        private string tenTK, mKhau;

        public ET_TaiKhoan()
        {
            maNV = new ET_NhanVien();
        }

        public ET_TaiKhoan(ET_NhanVien maNV, string tenTK, string mKhau)
        {
            this.MaNV = maNV;
            this.TenTK = tenTK;
            this.MKhau = mKhau;
        }

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MKhau { get => mKhau; set => mKhau = value; }
        public ET_NhanVien MaNV { get => maNV; set => maNV = value; }
    }
}
