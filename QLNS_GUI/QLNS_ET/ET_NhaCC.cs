using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_NhaCC
    {
        string maNCC, tenNCC, diaChi, sDT, ghiChu;

        public ET_NhaCC()
        {
        }

        public ET_NhaCC(string maNCC, string tenNCC, string diaChi, string sDT, string ghiChu)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.DiaChi = diaChi;
            this.SDT = sDT;
            this.GhiChu = ghiChu;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
