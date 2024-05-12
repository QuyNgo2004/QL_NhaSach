using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap nhaCungCap = new DAL_NhaCungCap();

        public IQueryable LoadNhaCC()
        {
            return nhaCungCap.LoadNhaCungCap();
        }
        public bool ThemNhaCC(ET_NhaCC ncc)
        {
            return nhaCungCap.ThemNhaCungCap(ncc);
        }
        public bool XoaNhaCC(string maNCC)
        {
            return nhaCungCap.XoaNhaCungCap(new ET_NhaCC { MaNCC = maNCC});
        }
        public bool SuaNhaCC(ET_NhaCC ncc)
        {
            return nhaCungCap.SuaNhaCungCap(ncc);
        }
    }
}
