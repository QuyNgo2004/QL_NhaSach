using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_DanhMuc : DAL_DATA
    {
        DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadDanhMuc()
        {
            
           IQueryable ds = from item in data.Data.DanhMucs 
                           select item;
           
            return ds;
        }
        //Them danh muc
        public bool ThemDanhMuc(ET_DanhMuc danhMuc)
        {
            try
            {
                DanhMuc dm = new DanhMuc
                {
                    maDM = danhMuc.MaDM,
                    tenDM = danhMuc.TenDM,
                    ghiChu = danhMuc .GhiChu
                };
                data.Data.DanhMucs.InsertOnSubmit(dm);
            }catch (Exception ex)
            {
                return false;
            }
            finally
            {
                data.Data.SubmitChanges();
            }
            return true;
        }
        //Xoa danh muc
        public bool XoaDanhMuc(ET_DanhMuc danhMuc)
        {
            try
            {
                var list = from item in data.Data.DanhMucs where item.maDM == danhMuc.MaDM
                           select item;
                foreach (var item in list)
                {
                    data.Data.DanhMucs.DeleteOnSubmit(item);
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
        //Sua danh muc
        public bool SuaDanhMuc(ET_DanhMuc danhMuc)
        {
            try
            {
                var suaDM = data.Data.DanhMucs.Single(DanhMuc => DanhMuc.maDM == danhMuc.MaDM);
                suaDM.tenDM = danhMuc.TenDM;
                suaDM.ghiChu = danhMuc.GhiChu;
            }catch(Exception ex)
            {
                return false;
            }
            finally { data.Data.SubmitChanges(); }
            return true;
        }
    }
}
