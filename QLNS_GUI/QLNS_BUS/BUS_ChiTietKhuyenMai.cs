using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_ChiTietKhuyenMai
    {
        DAL_CTKhuyenMai ctkm = new DAL_CTKhuyenMai();
        public IQueryable LoadCTKM()
        {
            return ctkm.LoadCTKhuyenMai();
        }
        public IQueryable LoadCTKM(int maSP)
        {
            return ctkm.LoadCTKhuyenMai(maSP);
        }
        public bool ThemCTKM(ET_CTKhuyenMai ct)
        {
            return ctkm.ThemCTKhuyenMai(ct);
        }
        public bool XoaCTKM(ET_CTKhuyenMai ct)
        {
            return ctkm.XoaCTKhuyenMai(ct) ;
        }
        public bool SuaCTKM(ET_CTKhuyenMai ct)
        {
            return ctkm.SuaCTKhuyenMaiTheoKM(ct) ;
        }
    }
}
