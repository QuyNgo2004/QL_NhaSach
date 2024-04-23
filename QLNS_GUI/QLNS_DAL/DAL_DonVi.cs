using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_DonVi
    {
        DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public List<QLNS_ET.ET_DonVi> LoadDonVi()
        {

            List<QLNS_ET.ET_DonVi> dsDonVi = new List<QLNS_ET.ET_DonVi>();
            var ds = from dv in data.Data.DonVis
                     join dm in data.Data.DanhMucs
                     on dv.maDM equals dm.maDM
                     select new { dv.maDV, dv.donVi1, dv.ghiChu, dm.tenDM };
            foreach (var item in ds)
            {

                QLNS_ET.ET_DonVi dv = new QLNS_ET.ET_DonVi
                {
                    MaDM = new ET_DanhMuc { TenDM = item.tenDM },
                    MaDV = item.maDV,
                    TenDV = item.donVi1,
                    GhiChu = item.ghiChu
                };
                dsDonVi.Add(dv);
            }
            return dsDonVi;
        }
        //Load danh muc theo danh muc
        public List<QLNS_ET.ET_DonVi> LoadTheLoaiDM(string maDM)
        {

            List<QLNS_ET.ET_DonVi> dsDonVi = new List<QLNS_ET.ET_DonVi>();
            var ds = from dv in data.Data.DonVis
                     join dm in data.Data.DanhMucs
                     on dv.maDM equals dm.maDM
                     where maDM == dv.maDM
                     select new { dv.maDV, dv.donVi1, dv.ghiChu };
            foreach (var item in ds)
            {

                QLNS_ET.ET_DonVi dv = new QLNS_ET.ET_DonVi
                {
                    MaDV = item.maDV,
                    TenDV = item.donVi1,
                    GhiChu = item.ghiChu
                };
                dsDonVi.Add(dv);
            }
            return dsDonVi;
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
                data.Data.DonVis.InsertOnSubmit(dv);
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
        public bool XoaTheLoai(ET_DonVi donVi)
        {
            try
            {
                var list = from item in data.Data.DonVis
                           where item.maDV == donVi.MaDV
                           select item;
                foreach (var item in list)
                {
                    data.Data.DonVis.DeleteOnSubmit(item);
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
        public bool SuaTheLoai(ET_DonVi donVi)
        {
            try
            {
                var suadv = data.Data.DonVis.Single(DonVi => DonVi.maDV == donVi.MaDV);
                suadv.maDM = donVi.MaDM.MaDM;
                suadv.donVi1 = donVi.TenDV;
                suadv.ghiChu = donVi.GhiChu;
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
