using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_DanhMuc
    {
        DAL_DanhMuc dal = new DAL_DanhMuc();
        public IQueryable LoadDSDanhMuc()
        {
            
            return dal.LoadDanhMuc();
        }
        public bool ThemDanhMuc(ET_DanhMuc danhMuc)
        {
            return dal.ThemDanhMuc(danhMuc);
        }
        public bool XoaDanhMuc(ET_DanhMuc danhMuc)
        {
            return dal.XoaDanhMuc(danhMuc);
        }
        public bool SuaDanhMuc(ET_DanhMuc danhMuc)
        {
            return dal.SuaDanhMuc(danhMuc);
        }
    }
}
