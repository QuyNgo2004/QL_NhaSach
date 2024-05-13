using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan tk = new DAL_TaiKhoan();
        DAL_NhanVien nv = new DAL_NhanVien();
        public bool ThemTK(string maNV)
        {
            return tk.ThemTK(maNV);
        }
        public string KTTaiKhoan((string,string) tkhoan)
        {
            return tk.KTTaiKhoan(tkhoan);
        }
        public bool XoaTK(string maNV)
        {
            return tk.XoaTK(maNV);
        }
        public bool SuaTK(string maNV,string mKhau)
        {
            return tk.SuaTK(new ET_TaiKhoan { MaNV = new ET_NhanVien { MaNV = maNV},MKhau = mKhau});
        }
    }
}
