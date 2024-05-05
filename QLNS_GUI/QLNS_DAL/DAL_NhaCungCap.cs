using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_NhaCungCap
    {
        DAL_DATA data = new DAL_DATA();
        //Load Nha cung cap
        public IQueryable LoadNhaCungCap()
        {

            IQueryable ds = from item in data.Data.NhaCCs select item;

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
                data.Data.NhaCCs.InsertOnSubmit(nhacc);
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
        //Xoa Nha cung cap
        public bool XoaNhaCungCap(ET_NhaCC ncc)
        {
            try
            {
                var list = from item in data.Data.NhaCCs
                           where item.maNCC == ncc.MaNCC
                           select item;
                foreach (var item in list)
                {
                    data.Data.NhaCCs.DeleteOnSubmit(item);
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
        //Sua Nha cung cap
        public bool SuaNhaCungCap(ET_NhaCC ncc)
        {
            try
            {
                var suaDM = data.Data.NhaCCs.Single(NhaCC => NhaCC.maNCC == ncc.MaNCC);
                suaDM.tenNCC = ncc.TenNCC;
                suaDM.diaChi = ncc.DiaChi;
                suaDM.sDT = ncc.SDT;
                suaDM.ghiChu = ncc.GhiChu;
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
