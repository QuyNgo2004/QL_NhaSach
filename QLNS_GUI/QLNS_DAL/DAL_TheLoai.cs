using QLNS_ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_TheLoai
    {
        DAL_DATA data = new DAL_DATA();
        //Load the loai
        public IQueryable LoadTheLoai()
        {
            IQueryable ds = from tl in data.Data.TheLoais
                     join dm in data.Data.DanhMucs
                     on tl.maDM equals dm.maDM
                     select new { MãTL = tl.maTL,TênTL = tl.tenTL,GhiChu = tl.ghiChu,TênDM = dm.tenDM };
           
            return ds;
        }
        //Load the loai theo the loai
        public IQueryable LoadTheLoaiDM(string maDM)
        {

            IQueryable ds = from tl in data.Data.TheLoais
                     join dm in data.Data.DanhMucs
                     on tl.maDM equals dm.maDM
                     where maDM == tl.maDM
                     select new { MãTL = tl.maTL, TênTL = tl.tenTL, GhiChu = tl.ghiChu, TênDM = dm.tenDM };

            return ds;
        }
        //Them the loai
        public bool ThemTheLoai(ET_TheLoai theLoai)
        {
            try
            {
                TheLoai tl = new TheLoai
                {
                    maDM = theLoai.MaDM.MaDM,
                    maTL = theLoai.MaTL,
                    tenTL = theLoai.TenTL,
                    ghiChu = theLoai.GhiChu
                };
                data.Data.TheLoais.InsertOnSubmit(tl) ;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                data.Data.SubmitChanges();
            }
            return true;
        }
        //Xoa the loai
        public bool XoaTheLoai(ET_TheLoai theLoai)
        {
            try
            {
                var list = from item in data.Data.TheLoais
                           where item.maTL == theLoai.MaTL
                           select item;
                foreach (var item in list)
                {
                    data.Data.TheLoais.DeleteOnSubmit(item);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                data.Data.SubmitChanges();
            }
            return true;
        }
        //Sua the loai
        public bool SuaTheLoai(ET_TheLoai theLoai)
        {
            try
            {
                var suaTL = data.Data.TheLoais.Single(TheLoai => TheLoai.maTL == theLoai.MaTL);
                suaTL.maDM = theLoai.MaDM.MaDM;
                suaTL.tenTL = theLoai.TenTL;
                suaTL.ghiChu = theLoai.GhiChu;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { data.Data.SubmitChanges(); }
            return true;
        }
    }
}
