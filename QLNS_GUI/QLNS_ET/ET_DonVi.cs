using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_DonVi
    {
        private ET_DanhMuc maDM;
        private string tenDV, ghiChu;
        private int maDV;
        public ET_DonVi()
        {
            maDM = new ET_DanhMuc();
        }

        public ET_DonVi(int maDV, ET_DanhMuc maDM, string tenDV, string ghiChu)
        {
            this.MaDV = maDV;
            this.MaDM = maDM;
            this.TenDV = tenDV;
            this.GhiChu = ghiChu;
        }

        public int MaDV { get => maDV; set => maDV = value; }
        public ET_DanhMuc MaDM { get => maDM; set => maDM = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
