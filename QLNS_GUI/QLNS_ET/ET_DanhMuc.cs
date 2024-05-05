using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_DanhMuc
    {
        private string maDM, tenDM, ghiChu;

        public string MaDM { get => maDM; set => maDM = value; }
        public string TenDM { get => tenDM; set => tenDM = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public ET_DanhMuc(string maDM, string tenDM, string ghiChu)
        {
            this.MaDM = maDM;
            this.TenDM = tenDM;
            this.GhiChu = ghiChu;
        }

        public ET_DanhMuc()
        {
        }
    }
}
