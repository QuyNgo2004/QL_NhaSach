using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_DonVi :DAL_DATA
    {
        //DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadDonVi()
        {
            IQueryable ds = from dv in Data.DonVis
                     join dm in Data.DanhMucs
                     on dv.maDM equals dm.maDM
                     select new {MãDV = dv.maDV,ĐơnVị = dv.donVi1,GhiChú =  dv.ghiChu,TênDM =  dm.tenDM };
            return ds;
        }
        //Load danh muc theo danh muc
        public IQueryable LoadTheLoaiDM(string maDM)
        {

          IQueryable ds = from dv in Data.DonVis
                     join dm in Data.DanhMucs
                     on dv.maDM equals dm.maDM
                     where maDM == dv.maDM
                     select new { MãDV = dv.maDV, ĐơnVị = dv.donVi1, GhiChú = dv.ghiChu, TênDM = dm.tenDM };
           
            return ds;
        }
        //Them danh muc
        public bool ThemTheLoai(ET_DonVi donVi)
        {
            try
            {
                DonVi dv = new DonVi
                {
                    maDM = donVi.MaDM.MaDM,
                    maDV = donVi.MaDV,
                    donVi1 = donVi.TenDV,
                    ghiChu = donVi.GhiChu
                };
                Data.DonVis.InsertOnSubmit(dv);
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
        //Xoa danh muc
        public bool XoaTheLoai(ET_DonVi donVi)
        {
            try
            {
                var list = from item in Data.DonVis
                           where item.maDV == donVi.MaDV
                           select item;
                foreach (var item in list)
                {
                    Data.DonVis.DeleteOnSubmit(item);
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
        //Sua danh muc
        public bool SuaTheLoai(ET_DonVi donVi)
        {
            try
            {
                var suadv = Data.DonVis.Single(DonVi => DonVi.maDV == donVi.MaDV);
                suadv.maDM = donVi.MaDM.MaDM;
                suadv.donVi1 = donVi.TenDV;
                suadv.ghiChu = donVi.GhiChu;
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
