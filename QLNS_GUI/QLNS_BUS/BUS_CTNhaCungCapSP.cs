using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_CTNhaCungCapSP
    {
        DAl_CTNhaCungCap sp = new DAl_CTNhaCungCap();
        public IQueryable LoadDSSPTheoNCC()
        {
            return sp.LoadCTNhaCungCap();
        }
        public bool ThemSPCC(ET_CTNhaCC ctsp)
        {
            return sp.ThemCTNhaCungCap(ctsp);
        }
        public bool XoaSPCC(ET_CTNhaCC ctsp)
        {
            return sp.XoaCTNhaCungCap(ctsp) ;
        }
        public bool SuaSPCC(ET_CTNhaCC ctsp)
        {
            return sp.XoaCTNhaCungCap(ctsp);
        }
        public bool XoaSPCCMASP(int MaSP)
        {
            return sp.XoaCTNhaCungCapMaSP(MaSP);
        }
    }
}
