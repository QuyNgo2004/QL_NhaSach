using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_TheLoai
    {
        ET_DanhMuc maDM;
        string maTL, tenTL, ghiChu,tenDM;

        public ET_TheLoai()
        {
            maDM = new ET_DanhMuc();
        }

        public ET_TheLoai(string maTL, ET_DanhMuc maDM, string tenTL, string ghiChu)
        {
            this.MaTL = maTL;
            this.MaDM = maDM;
            this.TenTL = tenTL;
            this.GhiChu = ghiChu;
        }

        public string MaTL { get => maTL; set => maTL = value; }
        public ET_DanhMuc MaDM { get => maDM; set => maDM = value; }
        public string TenDM { get => tenDM = MaDM.TenDM; set => tenDM = value; }
        public string TenTL { get => tenTL; set => tenTL = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        
    }
}
