using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_NhaCungCap :DAL_DATA
    {
        //DAL_DATA data = new DAL_DATA();
        //Load Nha cung cap
        public IQueryable LoadNhaCungCap()
        {

            IQueryable ds = from item in Data.NhaCCs select item;

            return ds;
        }
        //Them Nha cung cap
        public bool ThemNhaCungCap(ET_NhaCC ncc)
        {
            try
            {
                NhaCC nhacc = new NhaCC
                {
                    maNCC = ncc.MaNCC,
                    tenNCC = ncc.TenNCC,
                    diaChi = ncc.DiaChi,
                    sDT = ncc.SDT,
                    ghiChu = ncc.GhiChu
                };
                Data.NhaCCs.InsertOnSubmit(nhacc);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Data.SubmitChanges();
            }
            return true;
        }
        //Xoa Nha cung cap
        public bool XoaNhaCungCap(ET_NhaCC ncc)
        {
            try
            {
                var list = from item in Data.NhaCCs
                           where item.maNCC == ncc.MaNCC
                           select item;
                foreach (var item in list)
                {
                    Data.NhaCCs.DeleteOnSubmit(item);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Data.SubmitChanges();
            }
            return true;
        }
        //Sua Nha cung cap
        public bool SuaNhaCungCap(ET_NhaCC ncc)
        {
            try
            {
                var suaDM = Data.NhaCCs.Single(NhaCC => NhaCC.maNCC == ncc.MaNCC);
                suaDM.tenNCC = ncc.TenNCC;
                suaDM.diaChi = ncc.DiaChi;
                suaDM.sDT = ncc.SDT;
                suaDM.ghiChu = ncc.GhiChu;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { Data.SubmitChanges(); }
            return true;
        }
    }
}
