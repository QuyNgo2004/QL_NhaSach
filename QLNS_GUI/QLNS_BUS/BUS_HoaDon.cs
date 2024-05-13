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
        DAL_CTHoaDon ctHd = new DAL_CTHoaDon();

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
        public bool XoaHDNV(ET_HoaDon hoaDon)
        {
            foreach(ET_HoaDon hDon in hd.LoadHoaDonVN(hoaDon))
            {
                if (!ctHd.XoaCTHoaDon(hDon.MaHD))
                {
                    return false;
                }
            }
            if (!hd.XoaHoaDonVN(hoaDon))
            {
                return false;
            }
            return true;
        }
        public bool XoaHDKH(ET_HoaDon hoaDon)
        {
            return hd.XoaHoaDonKH(hoaDon);
        }
    }
}
