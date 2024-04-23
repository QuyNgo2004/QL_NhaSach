using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_SanPham
    {
        string  maTL, tenSP, maNCC, maDV;
        bool tKem;
        float giaSP;
        int sLTonKho, maSP;

        public ET_SanPham()
        {
        }

        public ET_SanPham(int maSP, string maTL, string tenSP, string maNCC, string maDV, bool tKem, float giaSP, int sLTonKho)
        {
            this.MaSP = maSP;
            this.MaTL = maTL;
            this.TenSP = tenSP;
            this.MaNCC = maNCC;
            this.MaDV = maDV;
            this.TKem = tKem;
            this.GiaSP = giaSP;
            this.SLTonKho = sLTonKho;
        }

        public int MaSP { get => maSP; set => maSP = value; }
        public string MaTL { get => maTL; set => maTL = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public bool TKem { get => tKem; set => tKem = value; }
        public float GiaSP { get => giaSP; set => giaSP = value; }
        public int SLTonKho { get => sLTonKho; set => sLTonKho = value; }
    }
}
