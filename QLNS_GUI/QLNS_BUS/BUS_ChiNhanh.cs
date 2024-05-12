using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_ChiNhanh
    {
        DAL_ChiNhanh chiNhanh = new DAL_ChiNhanh();

        public IQueryable LoadChiNhanh()
        {
            return chiNhanh.LoadChiNhanh();
        }
        public bool ThemChiNhanh(ET_ChiNhanh cn )
        {
            return chiNhanh.ThemChiNhanh(cn);
        }
        public bool SuaChiNhanh(ET_ChiNhanh cn)
        {
            return chiNhanh.SuaChiNhanh(cn);
        }
        public bool XoaChiNhanh(string maCN)
        {
            return chiNhanh.XoaChiNhanh(new ET_ChiNhanh { MaCN = maCN });
        }
    }
}
