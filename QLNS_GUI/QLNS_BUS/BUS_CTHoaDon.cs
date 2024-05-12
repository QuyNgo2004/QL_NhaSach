using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_CTHoaDon
    {
        DAL_CTHoaDon ctHD =new DAL_CTHoaDon();
        public bool ThemCTHD(ET_CTHoaDon ct)
        {
            return ctHD.ThemCTHoaDon(ct);
        }
        public IQueryable LoadCTHD(int maHD)
        {
            return ctHD.LoadCTHoaDon(maHD);
        }
    }
}
