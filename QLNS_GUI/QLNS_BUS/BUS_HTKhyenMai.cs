using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_HTKhyenMai
    {
        DAL_KhuyenMai khuyenMai = new DAL_KhuyenMai();

        public IQueryable LoadKhuyenMai ()
        {
            return khuyenMai.LoadKhuyenMai ();
        }
        
        public bool ThemKhuyenMai(ET_KhuyenMai km)
        {
            return khuyenMai.ThemKhuyenMai (km);
        }

        public bool XoaKhuyenMai(ET_KhuyenMai km)
        {
            return khuyenMai.XoaKhuyenMai(km);
        }
        public bool SuaKhuyenMai(ET_KhuyenMai km)
        {
            return khuyenMai.SuaKhuyenMai(km);
        }
    }
}
