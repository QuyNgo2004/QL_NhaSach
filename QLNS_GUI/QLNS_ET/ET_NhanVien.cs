using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_NhanVien
    {
        private string maNV, tenNV, diaChi, sDT, chucVu, gioiTinh;
        private DateTime ngaySinh, ngayTao = DateTime.Now;
        private ET_ChiNhanh maCN;

        public ET_NhanVien()
        {
            MaCN = new ET_ChiNhanh();
        }

        public ET_NhanVien(string maNV, string tenNV, string diaChi, string sDT, string chucVu, string gioiTinh, DateTime ngaySinh,  ET_ChiNhanh maCN)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.DiaChi = diaChi;
            this.SDT = sDT;
            this.ChucVu = chucVu;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            
            this.MaCN = maCN;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public ET_ChiNhanh MaCN { get => maCN; set => maCN = value; }
    }
}
