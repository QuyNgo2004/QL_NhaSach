using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nhanVien = new DAL_NhanVien();
        public IQueryable LoadNhanVien()
        {
            return nhanVien.LoadNhanVien();
        }
        public bool ThemNhanVien(ET_NhanVien nv)
        {
            return nhanVien.ThemNhanVien(nv);
        }
        public bool XoaNhanVien(string maNV)
        {
            return nhanVien.XoaNhanVien(new ET_NhanVien { MaNV = maNV });
        }
        public bool SuaNhanVien(ET_NhanVien nv)
        {
            return nhanVien.SuaNhanVien(nv);
        }
    }
}
