using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_CTNhaCC
    {
        ET_SanPham maSP;
        ET_NhaCC maNCC;
        string  ghiChu;
        int maCTNhaCC, sL;
        DateTime ngayCC;

        public ET_CTNhaCC()
        {
            maSP =new ET_SanPham();
            maNCC = new ET_NhaCC();
        }

        public ET_CTNhaCC(ET_SanPham maSP, ET_NhaCC maNCC, string ghiChu, int maCTNhaCC, int sL, DateTime ngayCC)
        {
            this.MaSP = maSP;
            this.MaNCC = maNCC;
            this.GhiChu = ghiChu;
            this.MaCTNhaCC = maCTNhaCC;
            this.SL = sL;
            this.NgayCC = ngayCC;
        }

        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaCTNhaCC { get => maCTNhaCC; set => maCTNhaCC = value; }
        public int SL { get => sL; set => sL = value; }
        public DateTime NgayCC { get => ngayCC; set => ngayCC = value; }
        internal ET_SanPham MaSP { get => maSP; set => maSP = value; }
        internal ET_NhaCC MaNCC { get => maNCC; set => maNCC = value; }
    }
}
