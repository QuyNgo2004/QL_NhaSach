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
        //Load danh muc
        public List<QLNS_ET.ET_TheLoai> LoadTheLoai()
        {

            List<QLNS_ET.ET_TheLoai> dsTheLoai   = new List<QLNS_ET.ET_TheLoai>();
            var ds = from tl in data.Data.TheLoais
                     join dm in data.Data.DanhMucs
                     on tl.maDM equals dm.maDM
                     select new {tl.maTL,tl.tenTL,tl.ghiChu,dm.tenDM};
            foreach (var item in ds)
            {

                QLNS_ET.ET_TheLoai tl = new QLNS_ET.ET_TheLoai
                {
                    MaDM = new ET_DanhMuc { TenDM = item.tenDM },
                    MaTL = item.maTL,
                    TenTL = item.tenTL,
                    GhiChu = item.ghiChu
                };
                dsTheLoai.Add(tl);
            }
            return dsTheLoai;
        }
        //Load danh muc theo danh muc
        public List<QLNS_ET.ET_TheLoai> LoadTheLoaiDM(string maDM)
        {

            List<QLNS_ET.ET_TheLoai> dsTheLoai = new List<QLNS_ET.ET_TheLoai>();
            var ds = from tl in data.Data.TheLoais
                     join dm in data.Data.DanhMucs
                     on tl.maDM equals dm.maDM
                     where maDM == tl.maDM
                     select new { tl.maTL, tl.tenTL, tl.ghiChu };
            foreach (var item in ds)
            {

                QLNS_ET.ET_TheLoai tl = new QLNS_ET.ET_TheLoai
                {
                    MaTL = item.maTL,
                    TenTL = item.tenTL,
                    GhiChu = item.ghiChu
                };
                dsTheLoai.Add(tl);
            }
            return dsTheLoai;
        }
        //Them danh muc
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
        //Xoa danh muc
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
        //Sua danh muc
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
