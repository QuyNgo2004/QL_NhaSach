using QLNS_DAL;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_TheLoai
    {
        DAL_TheLoai dal = new DAL_TheLoai();
        public IQueryable LoadDSTheLoai()
        {

            return dal.LoadTheLoai();
        }
        public IQueryable LoadDSTheLoaiDM(string maDM)
        {
            return dal.LoadTheLoaiDM(maDM);
        }
        public bool ThemTheLoai(ET_TheLoai theLoai)
        {
            return dal.ThemTheLoai(theLoai);
        }
        public bool XoaTheLoai(ET_TheLoai theLoai)
        {
            return dal.XoaTheLoai(theLoai);
        }
        public bool SuaDanhMuc(ET_TheLoai theLoai)
        {
            return dal.SuaTheLoai(theLoai);
        }
    }
}
