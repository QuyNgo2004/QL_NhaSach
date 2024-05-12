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
        private ET_TheLoai maTL = new ET_TheLoai();
        private ET_NhaCC maNCC = new ET_NhaCC();
        private ET_DonVi  maDV = new ET_DonVi();
        private int tKem;
        private float giaSP;
        private int sLTonKho, maSP;

        public ET_SanPham()
        {
           
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
