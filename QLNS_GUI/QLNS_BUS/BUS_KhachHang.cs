using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang khachHang = new DAL_KhachHang();
        public IQueryable LoadKhachHang()
        {
            return khachHang.LoadKhachHang();
        }
        public bool ThemKhachHang(ET_KhachHang kh)
        {
            return khachHang.ThemKhachHang(kh);
        }
        public bool XoaKhachHang(string maKH)
        {
            return khachHang.XoaKhachHang(new ET_KhachHang { MaKH = maKH });
        }
        public bool SuaKhachHang(ET_KhachHang kh)
        {
            return khachHang.SuaKhachHang(kh);
        }
    }
}
