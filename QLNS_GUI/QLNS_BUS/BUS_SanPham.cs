using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_SanPham
    {
        DAL_SanPham sp = new DAL_SanPham();

        public IQueryable LoadSP()
        {
            return sp.LoadSanPham();
        }
        public bool ThemSP(ET_SanPham sanPham)
        {
            return sp.ThemSanPham(sanPham);
        }
        public bool XoaSP(int maSP)
        {
             return sp.XoaSanPham(new ET_SanPham { MaSP = maSP });
           
        }
        public bool SuaSLSoLuong(int SL, int MaSP)
        {
            return sp.SuaSLSanPham(-SL, MaSP);
        }
        public bool SuaSP(ET_SanPham sanPham)
        {
            return sp.SuaSanPham(sanPham);
        }
        public IQueryable TimMaSP(int  maSP)
        {
            return sp.TimMaSanPham(maSP);
        }
    }
}
