using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_ChiNhanh
    {
        DAL_DATA data = new DAL_DATA();
        //Load chi nhanh
        public IQueryable LoadChiNhanh()
        {

            IQueryable ds = from item in data.Data.ChiNhanhs select item;

            return ds;
        }
        //Them danh muc
        public bool ThemChiNhanh(ET_ChiNhanh chinhanh)
        {
            try
            {
                ChiNhanh cn = new ChiNhanh
                {
                    maCN = chinhanh.MaCN,
                    tenCN = chinhanh.TenCN,
                    diaChi = chinhanh.DiaChi
                };
                data.Data.ChiNhanhs.InsertOnSubmit(cn);
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
        //Xoa danh muc
        public bool XoaThemChiNhanh(ET_ChiNhanh chinhanh)
        {
            try
            {
                var list = from item in data.Data.ChiNhanhs
                           where item.maCN == chinhanh.MaCN
                           select item;
                foreach (var item in list)
                {
                    data.Data.ChiNhanhs.DeleteOnSubmit(item);
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
        public bool SuaChiNhanh(ET_ChiNhanh chinhanh)
        {
            try
            {
                var suaDM = data.Data.ChiNhanhs.Single(ChiNhanh => ChiNhanh.maCN == chinhanh.MaCN);
                suaDM.tenCN = chinhanh.TenCN;
                suaDM.diaChi = chinhanh.DiaChi;
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
