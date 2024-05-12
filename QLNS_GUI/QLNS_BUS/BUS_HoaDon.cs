using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon hd = new DAL_HoaDon();
        public IQueryable LoadHD()
        {
            return hd.LoadHoaDon();
        }
        public IQueryable LoadHD(DateTime date)
        {
            return hd.LoadHoaDonTheoNgay(date);
        }
        public int LayMaHoaDonMoiTao()
        {
            return hd.HoaDonMoiTao();
        }
        public bool ThemHD(ET_HoaDon hoaDon)
        {
            return hd.ThemHoaDon(hoaDon);
        }
        public bool SuaHD(ET_HoaDon hoaDon)
        {
            return hd.SuaHoaDon(hoaDon);
        }
    }
}
