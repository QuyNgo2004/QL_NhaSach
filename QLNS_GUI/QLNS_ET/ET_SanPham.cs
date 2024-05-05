using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_SanPham
    {
        private string tenSP;
        private ET_TheLoai maTL;
        private ET_NhaCC maNCC;
        private ET_DonVi  maDV;
        private int tKem;
        private float giaSP;
        private int sLTonKho, maSP;

        public ET_SanPham()
        {
            MaTL = new ET_TheLoai();
            MaNCC = new ET_NhaCC();
            MaDV = new ET_DonVi();
        }

        public ET_SanPham(int maSP, string maTL, string tenSP, string maNCC, int maDV, bool tKem, float giaSP, int sLTonKho)
        {
            this.MaSP = maSP;
            this.MaTL.MaTL = maTL;
            this.TenSP = tenSP;
            this.MaNCC.MaNCC = maNCC;
            this.MaDV.MaDV = maDV;
            if (tKem == true)
            {
                this.TKem = 1;
            }
            else this.TKem = 0;
            this.GiaSP = giaSP;
            this.SLTonKho = sLTonKho;
        }

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
      
        public float GiaSP { get => giaSP; set => giaSP = value; }
        public int SLTonKho { get => sLTonKho; set => sLTonKho = value; }
        public int TKem { get => tKem; set => tKem = value; }
        public ET_TheLoai MaTL { get => maTL; set => maTL = value; }
        public ET_NhaCC MaNCC { get => maNCC; set => maNCC = value; }
        public ET_DonVi MaDV { get => maDV; set => maDV = value; }
    }
}
